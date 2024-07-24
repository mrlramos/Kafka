# Kafka Study Repository

This repository is designed for learning and experimenting with Apache Kafka alongside .NET. It sets up a comprehensive environment using Docker to streamline the integration process.

## Overview

This project configures a Docker-based environment to run Apache Kafka, Zookeeper, and Kafdrop, as well as a .NET application acting as a Kafka message producer.

## Tech Stack

- **Docker**: A containerization platform that simplifies deploying applications in isolated, reproducible environments.
- **Apache Kafka**: A distributed event streaming platform known for its high throughput and low latency.
- **Zookeeper**: A centralized service for maintaining configuration information and providing distributed synchronization.
- **Kafdrop**: A web UI for visualizing and managing Kafka topics, brokers, and messages.
- **.NET (C#)**: A robust development framework from Microsoft, used for building a variety of applications including APIs and web services.
- **Confluent Kafka Client**: A .NET client library for interacting with Apache Kafka, enabling seamless message production and consumption.

## Project Structure

### Docker Services

- **Zookeeper**: Manages and coordinates Kafka brokers.
- **Kafka**: The core of the event streaming platform, handling data ingestion and processing.
- **Kafdrop**: Provides a web-based interface to monitor and manage Kafka clusters.

### .NET Application

- **ProducerService**: A service responsible for producing and sending messages to a Kafka topic.
- **ASP.NET Core**: An API that receives messages and leverages `ProducerService` to publish them to Kafka.

## Configuration

### Docker Compose

The `docker-compose.yml` file sets up and configures the services for Zookeeper, Kafka, and Kafdrop to work seamlessly together.

### .NET Application

The .NET application is configured to connect to Kafka using a `ProducerService`. It reads configuration settings from a configuration file and sends messages to a specified Kafka topic.

## Purpose

The goal of this repository is to provide a practical and easy-to-setup environment for exploring the integration of Apache Kafka with .NET applications, using Docker to manage dependencies and services.

## Getting Started

1. Clone this repository.
2. Run `docker-compose up` to start Kafka, Zookeeper, and Kafdrop services.
3. Configure the .NET application to connect to Kafka with the appropriate settings.
4. Use the API to send messages to Kafka and view them using Kafdrop.

This project is perfect for software engineers and developers looking to get hands-on experience with Kafka and .NET, providing insights into setting up, producing, and managing messages in a distributed system.
