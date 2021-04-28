# Levvel Cli Starter Net Api
A starter project for an API [.NET 5.0](https://dotnet.microsoft.com/download/dotnet/5.0) and [Entity Framework](https://docs.microsoft.com/en-us/ef/)

## Overview
This repository offers a basic structure for an Api project following a Clean Architecture. Swagger is added for an easy and quicker implementation. It already holds controllers, models, services, interfaces and a generic repository pattern that will help with the communication between the Api and our database. An In Memory database is set as default, as well a logging service with Nlog.

## Getting Started
Make sure you already have downloaded the [.Net 5.0 SDK](https://dotnet.microsoft.com/download/dotnet/5.0).

If you use the Lvl Cli to download the repo you can skip this steps, the Cli already did this for you!
1. Clone the repo
```bash
git clone git@github.com:GetLevvel/levvel-starter-net-api.git
cd levvel-starter-net-api
```

2. Install Dependencies
```bash
dotnet build
```

3. Run it
```bash
dotnet run
```

4. Enjoy!

## Dependencies/Plugins Added
* [Swagger](https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-5.0)
* [Entity Framework](https://docs.microsoft.com/en-us/ef/)
* [Entity Framework SqlServer](https://docs.microsoft.com/en-us/ef/core/providers/sql-server/?tabs=dotnet-core-cli)
* [AutoMapper](https://automapper.org/)
* [NLog](https://github.com/NLog/NLog/wiki/Getting-started-with-ASP.NET-Core-5)

## Configuration Files

## Available Commands

The following commands works only with the Levvel CLI:

1. New: creates a new .Net project from scratch with the default structure
```bash
lvl new net-api <projectName>
```

2. Generate: Creates a single component file (interface, controller or service) for your .Net project.
```bash
lvl generate net-api interface <interfaceName>

lvl generate net-api controller <controllerName>

lvl generate net-api service <serviceName>
```
Creating these files will automatically add it respective prefix/sufix for each file type as follows: 
"<name>Controller" for controllers, "I<name>" for interfaces and "<name>Service" for services

## Features

### Clean Architecture

### Swagger

### Design Patterns

#### Repository Pattern

### Unit tests
