# TextCalculator

## Purpose
The TextCalculator aims to take a string of numbers as input, calculate their sum and return the result as a string.

## General info
The solution consists of multiple components:

* TextCalculator & TextCalculatorTests:
  This contains the core logic for how to input a string number to get the numbers' sum. It also includes unit tests using xUnit.
  
* TextCalculatorApi:
  This is a .NET Core Web API project that exposes an endpoint for calculating the sum of numbers. When running the project. Swagger UI will be automatilly opened when running the project.
  
* TextCalculatorWebApp:
  This web application provides a simple UI for the user to input numbers and display the sum result. It integrates with the *TextCalculatorApi* to perform calculations.

## Run Locally
```
https://github.com/sng525/TextCalculator.git
```

IDE: Visual Studio
.NET 7.0 or above 

To run TextCalculatorApi, ensure the API is configured to use your correct port. It can be modified under Propertiers -> launchSettings.json
