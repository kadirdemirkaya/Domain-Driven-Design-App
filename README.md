# DomainDrivenDesignApp

Domain Driven Design is a method that focuses on understanding business logic in the software development process and reflecting it on the design, and it generally focuses on a specific area of ​​the business (domain). This project includes an example project in which the rules of Domain Driven Design are tried to be applied.

## Information About the Project

- There are 5 layers: API, Application, Contracts, Domain and Infrastructure.
- Database operations were carried out in the Persistence folder within the Infrastructure layer.
- cqrs, event, jwt, healt check, log etc. has multiple records.
- The project was developed using MsSql.

## Loading

Enter the terminal.

To clone the project

```bash
  git clone https://github.com/kadirdemirkaya/DomainDrivenDesignApp.git
```

You need to change the information in the .json file in the API layer according to your needs.

```bash
  appsettings.json
```

You need to enter the infrastructure layer, create migrations and then save them.

```bash
  dotnet ef migrations add "your_migration_name"
  dotnet ef database update
```

Enter the API layer and then launch the project

```bash
  dotnet run
```
