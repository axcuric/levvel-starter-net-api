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
* [Clean Architecture](https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures#clean-architecture)
* [Swagger](https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-5.0)
* [Entity Framework](https://docs.microsoft.com/en-us/ef/)
* [Entity Framework SqlServer](https://docs.microsoft.com/en-us/ef/core/providers/sql-server/?tabs=dotnet-core-cli)
* [AutoMapper](https://automapper.org/)
* [NLog](https://github.com/NLog/NLog/wiki/Getting-started-with-ASP.NET-Core-5)

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

## Configuration Files
First things first.
Where all the API configuration takes part. This method calls the configurations of the Api, instead of having the Startup.cs doing everything.
```bash
Startup.cs
public void ConfigureServices(IServiceCollection services)
```

When you add a new Service, Interface, Model, or RepositoryManager, you WILL need to add this to our ConfigureScopedServices. Be sure to double check this method, this will give you a 500 Internal Server Error when trying to test your Api.

```bash
public static class ServiceExtensions
public static void ConfigureScopedServices(this IServiceCollection service)
```

This configures Swagger to add the comments as documentation to our Swagger starter page.

```bash
public static void ConfigureSwagger(this IServiceCollection services)
```

On Layer SharedKernel we will find NLog dependency. There's the Nlog.config file, please give it a look, since we default some values as the folder where the logs will be saved, files names, and added an internal config as well.

## Features

### Clean Architecture
This architecture separates business logic and application model at the center of the application. Instead of having business logic depend on data access or other infrastructure concerns, this dependency is inverted: infrastructure and implementation details depend on the Core. This functionality is achieved by defining abstractions, or interfaces, in the Core, which are then implemented by types defined in the Infrastructure layer. And our sharedKernel manages services that will be accessible all over the solution, 

### Swagger
Swagger is a super useful tool that helps us with the API Design, Development, Documentation and Testing which is what is intially on this repo.

Just by adding a new controller and writting some comments on top of your methods on the API it would automatically generate a nice looking web page with all the web methods and their response codes, response types and request types as well.


Here's an example of the comments for your controllers:
```bash
  /// <summary>
  /// Retrieves all Users from the Db.
  /// </summary>
  /// <response code="200">Returned if the User was created</response>
  /// <response code="404">Returned if the User items weren&#8217;t found</response>
```

### Design Patterns

#### Repository Pattern
There are two main Generic Repositories, ReadRepository<T>, and WriteRepository<T>, and the way to use them is with the RepositoryManager<T>.
  Once a new Model is created, there is no need to extend the read, and write actions of a repository, instead we can use the Generic RepositoryManager to read or write to the Database.

 Example:
```bash
1)	Let’s create a Repository with the Name “Car” which will have properties like Id, Model, etc.
```
```bash
2)	In the ServiceExtensions static class, you need to add the Scoped (or any servicetype that apply) like this: service.AddScoped<ICar, Car>();
```
```bash
3)	In the controller’s constructor you need to inject it like this: 
private readonly IRepositoryManager<Car> _repositoryManager;       
       public CarController(ILoggerService logger, 
            IRepositoryManager<Car> repositoryManager,
            IUserService userService,
            IMapper mapper)
            {
            _logger = logger;
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _userService = userService;
      }
```

```bash
4)	And then you can use it inside of any method that you create like this:
a.	_repositoryManager.ReadService.GetAll(true);

b.	_repositoryManager.ReadService.GetById(id);

c.	repositoryManager.WriteService.Update(car);
if (_repositoryManager.Save())
{
    return Ok();
}
return NotFound();
```

### Unit tests
Coming soon!
