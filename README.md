# TextCalculator

## Purpose
The TextCalculator aims to take a string of numbers as input, calculate their sum, and return the result as a string.

## General info
The solution consists of multiple components:

* **TextCalculator & TextCalculatorTests**:
  This contains the core logic for how to input a string number to get the numbers' sum. It also includes unit tests using xUnit.
  
* **TextCalculatorApi**:
  This is a .NET Core Web API project that exposes an endpoint for calculating the sum of numbers. Swagger UI will be automatically opened when running the project.
  
* **TextCalculatorWebApp**:
  This web application provides a simple UI for users to input numbers and display the sum result. It integrates with the *TextCalculatorApi* to perform calculations.

## Run Locally
```
https://github.com/sng525/TextCalculator.git
```

IDE: Visual Studio
.NET 7.0 or above 

To run TextCalculatorApi, please ensure the API is configured to use your right port. It can be modified under Properties -> launchSettings.json
