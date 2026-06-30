Library Portal 📚

A full-stack Library Management System built with ASP.NET Core MVC.

Features


🔐 User Authentication — Register, Login, Logout using ASP.NET Identity
📖 Book Management — Add, Edit, Delete books
🔍 Search — Search books by title
🔄 Borrow / Return Tracking — Track which user borrowed which book
🎨 Responsive UI — Built with Bootstrap 5


Tech Stack


Backend: ASP.NET Core MVC, C#
Database: SQLite with Entity Framework Core
Frontend: Razor Views, Bootstrap 5
Authentication: ASP.NET Core Identity


Screenshots
<img width="1751" height="892" alt="Screenshot 2026-06-30 091004" src="https://github.com/user-attachments/assets/042f59ca-ea1c-4b74-9337-d534186142d6" />

How to Run

bashgit clone https://github.com/hindumandala/library-portal.git
cd library-portal
dotnet restore
dotnet ef database update
dotnet run

Then open http://localhost:5176 in your browser.

Project Structure

LibraryPortal/
├── Controllers/      # Handles requests (BooksController, AccountController)
├── Models/            # Book model
├── Views/             # Razor (.cshtml) pages
├── Data/              # Database context (Entity Framework)
└── Program.cs         # App configuration

Author

Indu Mandala
GitHub: @hindumandala
