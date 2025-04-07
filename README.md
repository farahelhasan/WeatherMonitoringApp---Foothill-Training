# Weather Monitoring App

## Overview

The Weather Monitoring App is a C# console application that simulates a real-time weather monitoring and reporting service. The application receives and processes raw weather data in JSON and XML formats from various weather stations and activates different weather bots based on the received data.

## Features

- Accepts weather data in both JSON and XML formats.
- Implements various weather bots that respond to specific weather conditions:
  - **RainBot**: Activated when humidity exceeds a specified threshold.
  - **SunBot**: Activated when temperature rises above a specified threshold.
  - **SnowBot**: Activated when temperature drops below a specified threshold.
- Uses the **Strategy Pattern** to allow for extensibility in parsing different formats.
- Uses the **Observer Pattern** to notify all registered bots when new weather data is received.
- Configurati
