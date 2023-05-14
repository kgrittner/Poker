# Poker Game Console

## Description

This is a simple console-based poker game application using 3 cards and modified win position. 
Win Position are as follows:
1) Straight Flush
2) Three Of A Kind
3) Straight
4) Flush
5) Pair
6) High Card

## Installation

1. Clone the repository to your local machine.
2. Navigate to the project directory.

## Configuration

To configure the base path for the application, follow these steps:

1. Locate the `program.cs` file under the `PokerGameConsole` directory.
2. Open the `program.cs` file using a text editor.
3. Search for the line of code that sets the `BasePath` property.
4. Modify the `BasePath` property to the desired base path.

```csharp
// Set the BasePath to the desired path
private readonly static string BasePath = "YOUR_BASE_PATH"; // Example @"C:\Users\karlg\Downloads\CodeTest2\poker\Tests";
```

5. Save the `program.cs` file.

## Running the Application

To run the application, follow these steps:

1. Open the application and press start or F5

## Troubleshooting

- If you encounter any issues running the application, make sure you have the .NET Core SDK installed on your machine. You can download it from the official .NET website: https://dotnet.microsoft.com/download

- Double-check that the `BasePath` property is correctly configured in the `program.cs` file.

- If you continue to experience problems, feel free to open an issue on the project's GitHub repository for further assistance.

## License

This project is licensed under the MIT License. Please refer to the `LICENSE` file for more information.