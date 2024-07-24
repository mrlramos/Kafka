using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Confluent.Kafka;

namespace Kafka.Producer.API
{
    public class ProducerService
    {
        private readonly IConfiguration _configuration;
        private readonly ProducerConfig _producerConfig;
        private readonly ILogger<ProducerService> _loggerProducerService;

        public ProducerService(IConfiguration configuration, ILogger<ProducerService> loggerProducerService)
        {
            _configuration = configuration;
            _loggerProducerService = loggerProducerService;

            var bootstrap = _configuration.GetSection("KafkaConfig").GetSection("BoostrapServer").Value;
            _producerConfig = new ProducerConfig() {
                BootstrapServers = bootstrap
            };
        }

        public async Task<string> SendMessage(string message) 
        {
            var topic = _configuration.GetSection("KafkaConfig").GetSection("TopicName").Value;

            try 
            {
                using(var producer = new ProducerBuilder<string, string>(_producerConfig).Build())
                {
                    var result = await producer.ProduceAsync(topic: topic, new Message<string, string>(){Key = "Fruta", Value = message});
                    _loggerProducerService.LogInformation(result.Status.ToString() + " - " + message);

                    return result.Status.ToString() + " - " + message;
                } 
            }
            catch (Exception e) 
            {
                _loggerProducerService.LogError(e.Message);
                throw e;
            }
        }
    }
}