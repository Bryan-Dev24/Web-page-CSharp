# Library Management System in C#

## Description
Library management system developed in C# with two interfaces: Web (MVC) and Desktop (Windows Forms).

## Project Structure

- `Biblioteca.Core`: Shared class library
- `Biblioteca.Web`: Web MVC Application
- `Biblioteca.Desktop`: Desktop Windows Forms Application

## Features

- Book, author, and user management
- Loan and return tracking
- Advanced book search
- Report generation
- Multiple interfaces (Web and Desktop)

## Prerequisites

- .NET 8.0 SDK
- SQL Server 2019+ or SQLite
- Visual Studio 2022 (recommended) or VS Code

## Getting Started

1. Clone the repository:
   ```bash
   git clone [repository-url]
   cd "Biblioteca em C#"
   ```

2. Restore the packages:
   ```bash
   dotnet restore
   ```

3. Run database migrations:
   ```bash
   cd Biblioteca.Web
   dotnet ef database update
   ```

4. Start the web application:
   ```bash
   dotnet run
   ```
   
   Or open the solution in Visual Studio and press F5.

## Documentation

Check the `Documentation/` folder for:
- User manual
- API documentation
- Installation guide

## Contributing

1. Fork the project
2. Create your feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License.
