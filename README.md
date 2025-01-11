# Bookstore API

RESTful Web API built with ASP.NET Core for managing a bookstore's catalog. This API provides endpoints for performing CRUD operations on books, including their titles, publication years, and author information.

## Technologies Used

- ASP.NET Core 7.0
- Entity Framework Core
- SQL Server (LocalDB)
- Swagger/OpenAPI for documentation
- AutoMapper for object mapping

## Prerequisites

Before running this application, ensure you have the following installed:
- .NET 7.0 SDK or later
- SQL Server with LocalDB (comes with Visual Studio)
- Visual Studio 2022 or Visual Studio Code
- SQL Server Management Studio (SSMS) for database management (optional)

## Getting Started

### Installation

1. Clone the repository:
```bash
git clone [repository-url]
cd BookstoreAPI
```

2. Update the connection string in `appsettings.json`:
```json
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=BookstoreDB;Trusted_Connection=True;MultipleActiveResultSets=true"
    }
}
```

3. Install required NuGet packages:
```bash
dotnet restore
```

4. Apply database migrations:
```bash
dotnet ef database update
```

### Running the Application

Using Visual Studio:
1. Open the solution file in Visual Studio
2. Press F5 or click the "Run" button
3. The Swagger UI will automatically open in your browser

Using Command Line:
```bash
dotnet watch run
```

## API Endpoints

The API provides the following endpoints:

### Books

- `GET /api/Books` - Retrieve all books
- `GET /api/Books/{id}` - Retrieve a specific book by ID
- `POST /api/Books` - Create a new book
- `PUT /api/Books/{id}` - Update an existing book
- `DELETE /api/Books/{id}` - Delete a book

### Sample Requests

#### Create a Book
```json
POST /api/Books
{
    "title": "The Great Gatsby",
    "yearOfPublication": 1925,
    "authorName": "F. Scott Fitzgerald"
}
```

#### Update a Book
```json
PUT /api/Books/1
{
    "title": "The Great Gatsby",
    "yearOfPublication": 1925,
    "authorName": "Francis Scott Fitzgerald"
}
```

## Database Management

You can manage the database using SQL Server Management Studio (SSMS):
1. Open SSMS
2. Connect to: `(localdb)\mssqllocaldb`
3. Use Windows Authentication
4. Find your database (default name: "BookstoreDB")

## Project Structure

The solution follows a clean architecture pattern:

- `Models/` - Contains domain entities
- `DTOs/` - Data Transfer Objects for API operations
- `Data/` - Database context and configurations
- `Controllers/` - API endpoints implementation

## Error Handling

The API uses standard HTTP status codes:
- 200: Success
- 201: Created
- 204: No Content
- 400: Bad Request
- 404: Not Found
- 500: Internal Server Error

## API Documentation

Swagger documentation is available at `/swagger` when running the application. This provides:
- Interactive API documentation
- Request/response examples
- Test interface for all endpoints