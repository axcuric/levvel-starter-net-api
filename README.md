# Levvel Cli Starter Net Api
A starter project for an API [.NET 5.0](https://dotnet.microsoft.com/download/dotnet/5.0) and [Entity Framework](https://docs.microsoft.com/en-us/ef/)

## Overview
This repository offers an essential structure for a RestAPI project following a Clean Architecture. Swagger added for easy and quicker implementation. It already holds controllers, models, services, interfaces, and a generic repository pattern to help communicate between the RestAPI and our database. In-Memory database as default, as well as a logging service with Nlog.

## Getting Started
Make sure you already have installed the [.Net 5.0 SDK](https://dotnet.microsoft.com/download/dotnet/5.0).

If you use the Lvl Cli to download the repo, you can skip these steps. The lvl_cli already did this for you!
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

## Features

### Clean Architecture

### Swagger

### Design Patterns

#### Repository Pattern

### Unit tests
