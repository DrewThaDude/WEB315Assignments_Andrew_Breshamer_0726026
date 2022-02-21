# WEB315Assignments_Andrew_Breshamer_0726026
Assignment 1

dotnet new webapp -o RazorPagesChess code -r RazorPagesChess

dotnet dev-certs https --trust

dotnet watch run

[ctrl + c]

dotnet tool install --global dotnet-ef --version 5.*

dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*

dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.13

dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.0.13

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2

dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.13

dotnet-aspnet-codegenerator razorpage -m Chess -dc RazorPagesChessContext -udl -outDir Pages/Chess --referenceScriptLibraries -sqlite

dotnet ef migrations add InitialCreate

dotnet ef database update

dotnet ef migrations add InitialCreate

dotnet ef database update
