# Digital Games Online Marketplace Backend Service


## Overview
This project builds a robust and scalable .NET Core (C#) RESTful backend service for a digital games online marketplace application. 

## Goals
- Develop a RESTful backend service with .NET Core.
- Implement RESTful APIs for basic CRUD operations.
- Build a well-structured PostgreSQL database that includes at least 5 tables with foreign key relationships, and additional ASP Identity tables.
- Implement JWT for secure authentication.
- Integrate Identity Framework for user management and authorisation access control.
- Provide an email service for user registration.
- Comprehensive logging, error handling and validation.
- Extensive use of Dependency Injection.
- Additional features of API endpoint and database connection health checks.
- Deploy the service on Microsoft Azure.
- Maintain the codebase through GitHub.

## Functionalities

### RESTful API Development
- Adherence to REST principles and architecture to provide successful interaction with HTTP requests, allowing for CRUD operations to be performed on relevant entities.
- JSON response formatting allowing for easy consumption of API endpoints in Postman.

### Database Design and Interaction
- Relational database schema design created with normalisation principles.
- Foreign key relationships included for data integrity in one-to-many relationships, and link tables included for many-to-many relationships.
- RESTful API endpoints utilisied for CRUD operations via controllers.

### User Authentication and Authorisation
- JWT implementation for authentication of users and access privileges.
- Identity Framework integration for account and role management authorisation.

### Email Service Integration
- SMTP-based email notifications.
- SMTP settings management and error handling, customisable email template.

### Error Handling and Validation
- Comprehensive error handling and validation throughout the program.
- Proper HTTP status code usage and additional detail on error messages provided at API endpoints where appropriate.

### Logging and Health Checks
- Extensive and detailed logging for application events and errors, printed to the console for the developer to easily view and understand.
- Additional features of health check endpoint for the service, as well as a health check endpoint for database connectivity.

### Deployment on Azure
- Backend service fully deployed and accessible on Azure.
- Connected and accessible PostgreSQL database also hosted on Azure.

### Code Organisation
- Code organised as per the MVC (without views) design pattern, with database models representing tables stored in Models, and the controller logic for the API endpoints to these stored in Controllers.
- Controllers also contain the Account and Roles controllers for user authorisation and identity framework integration, as well as the health check controller. 
- Extensive Dependency Injection (database context, health checks, ILogger) enhances modularity contributes further to separation of concerns, allowing for strong code readability and maintainability.

### Document and Version Control
- Consistent and regular commits to the GitHub repository for version control, providing a full history of the project's development, the use of multiple branches for developing and testing different features, and the utilisation of pull requests to integrate these branches into the main branch.
- This readme file provides a clear overview and outline of the project's goals, functionalities and technologies used.

## Technologies Used

#### .NET Core (C#)
- Core framework for building the RESTful backend service, implementing the MVC architecture and providing the runtime for building the backend web service.

#### Packages, Frameworks and Libraries
- Microsoft.AspNetCore.App & Microsoft.NETCore.App - (Meta-packages for ASP.NET Core and .NET Core that include all the necessary libraries and dependencies needed to build an application)
- Microsoft.AspNetCore.Authentication.JwtBearer - (enables JWT [JSON Web Token] authentication)
- Microsoft.AspNetCore.Identity.EntityFrameworkCore - (integrates ASP.NET Core Identity with Entity Framework Core for identity data like users, roles, claims)
- Microsoft.EntityFrameworkCore - (object-relation mapper for .NET, allows interaction using C# objects)
- Npgsql.EntityFrameworkCore.PostgreSQL - (enables use of PostgreSQL database with EF Core)
- Microsoft.EntityFrameworkCore.Tools - (provides tools such as migrations
- Microsoft.Extensions.Identity.Core - (includes user and role management)
- Microsoft.VisualStudio.Web.CodeGeneration.Design - (used with Visual Studio to provide code generation)
- Microsoft.AspNetCore.OpenApi - (generates OpenAPI/Swagger documentation)
- Swashbuckle.AspNetCore - (generates Swagger/OpenAPI UI to inspect and test the API endpoints)
- MailKit - (enables sending emails with .NET Core)

#### PostgreSQL
- Relational database system used for storing and managing the application data locally.

#### JWT (JSON Web Tokens)
- Secure information transmission between parties, used in the backend service for secure authentication.

#### Postman
- Tool used for testing and consuming the API endpoints (HTTP requests to perform CRUD operations, user registration and sign in, role management).

#### SMTP and Email Services
- Used to send emails from the application for user registration.

#### Dependency Injection
- Technology approach used throughout the application to achieve loose coupling.
- ILogger used to capture application logs and help with debugging and monitor the application.

#### ASP.NET Core Health Checks
- Additional feature used to check the health and availability of the application and its database connectivity.

#### Azure Web App
- The cloud platform used to host and deploy the .NET Core backend service.

#### PostgreSQL for Azure
- The cloud-based instance of PostgreSQL database hosted on Azure and connected to the backend service.

#### GitHub
- Version control and project history.
