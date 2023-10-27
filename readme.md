# Commands

`bash
<!-- initial config -->
dotnet new sln --name "Selenium.App"
dotnet new globaljson
dotnet new console -o "Application"
dotnet sln add "Application/Application.csproj"

<!-- add selenium -->
dotnet add package Selenium.WebDriver --version 4.14.1
dotnet add package Selenium.WebDriver.ChromeDriver --version 117.0.5938.14900
`
