# Quiz Application

## Description
This project is a simple C# .NET Windows application developed overnight for a class assignment. It uses Entity Framework with SQLite3 for database operations and WinForms for the user interface. The application serves as a basic quiz manager, where users can create and take quizzes. It's a straightforward project and a good starting point for beginners looking to learn about desktop app development using C#, database integration, and basic CRUD operations.

## Features
- **Entity Framework**: Object-relational mapping (ORM) framework used for database operations.
- **SQLite3**: Embedded relational database management system used for local storage.
- **WinForms**: GUI framework used for developing desktop applications.
- **Quiz Management**: Users can create, take, and review quizzes.

## Installation
1. **Clone Repository:**
   ```
   git clone https://github.com/Sayemahamed/Quiz-Application.git
   ```
   
2. **Restore Packages:**
   Open the solution in Visual Studio and restore NuGet packages.

3. **Database Setup:**
   - The SQLite database file (`Data.db`) is included in the project.
   - Ensure Entity Framework migrations are applied to initialize the database schema.

## Usage
1. **Run Application:**
   - Build and run the application in Visual Studio.
   
2. **Functionality:**
   - **Create a Quiz**: Add questions and answers for a quiz.
   - **Take a Quiz**: Users can select a quiz and attempt to answer the questions.
   - **Review Scores**: After taking a quiz, users can view their scores.

## Contributing
Contributions are not expected for this assignment.

## License
This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

## Credits
- Complete C# Masterclass course from Udemy
