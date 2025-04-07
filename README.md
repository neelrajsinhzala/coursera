# SimpleUserAPI

This project is a basic ASP.NET Core Web API that allows CRUD operations (Create, Read, Update, Delete) on a list of users. It also includes middleware for logging and Swagger for API documentation.

## ✅ Features

- Create, Read, Update, and Delete Users
- Swagger UI for testing endpoints
- Middleware for logging HTTP requests
- Model validation to ensure valid user data
- Built with .NET 9 and ASP.NET Core Web API

## 📦 Technologies Used

- ASP.NET Core 9.0
- C#
- Swagger (OpenAPI)
- Git & GitHub

## 📂 Project Structure

```
SimpleUserAPI/
├── Controllers/
│   └── UserController.cs
├── Models/
│   └── User.cs
├── Program.cs
├── Properties/
│   └── launchSettings.json
└── README.md
```

## 🚀 How to Run

Make sure you have [.NET SDK](https://dotnet.microsoft.com/download) installed.

```bash
git clone https://github.com/your-username/your-repo-name.git
cd SimpleUserAPI
dotnet restore
dotnet build
dotnet run
```

Then navigate to:

- Swagger UI: [http://localhost:5000/swagger](http://localhost:5000/swagger)

## 🔁 API Endpoints

| Method | Endpoint            | Description         |
|--------|---------------------|---------------------|
| GET    | `/api/user`         | Get all users       |
| GET    | `/api/user/{id}`    | Get user by ID      |
| POST   | `/api/user`         | Create a new user   |
| PUT    | `/api/user/{id}`    | Update a user       |
| DELETE | `/api/user/{id}`    | Delete a user       |

## 👨‍💻 Author

- **Neelrajsinh Zala**
