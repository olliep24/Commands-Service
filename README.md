**Built in conjunction with**
- [Platform-Service](https://github.com/olliep24/Platforms-Service)
- [k8s-Platforms-and-Commands-Services](https://github.com/olliep24/k8s-Platforms-and-Commands-Services)

This ASP.NET Core Web API project is a microservice designed to provide information about commands used with platforms such as .NET, SQL Server, Docker, etc. The command model is defined below
```csharp
public class Command
{
    public required int Id { get; set; }

    public required string HowTo { get; set; }

    public required string CommandLine { get; set; }

    public required int PlatformId { get; set; }

    public Platform? Platform { get; set; }
}
```
The project implements basic CRUD operations with minimal business logic, allowing the focus to be on deploying microservices using Docker and Kubernetes. 
The service uses gRPC for synchronous communication and RabbitMQ for asynchronous communication with other microservices.

This service listens for platform creation events on the message bus, so it can add the platform to its database. Additionally, the service will communicate synchronously with the
[platform service](https://github.com/olliep24/Platforms-Service) on startup to populate its database with the current platforms.
