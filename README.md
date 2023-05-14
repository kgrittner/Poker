# Poker Game Console

## Description

This is a simple console-based poker game application. The program allows you to play poker against computer players in a text-based interface.

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

1. Open a command prompt or terminal window.
2. Navigate to the project directory.
3. Run the following command to build the application:

```shell
dotnet build
```

4. After a successful build, run the following command to start the application:

```shell
dotnet run
```

5. The application will start, and you can follow the on-screen instructions to play the poker game.

## Troubleshooting

- If you encounter any issues running the application, make sure you have the .NET Core SDK installed on your machine. You can download it from the official .NET website: https://dotnet.microsoft.com/download

- Double-check that the `BasePath` property is correctly configured in the `program.cs` file.

- If you continue to experience problems, feel free to open an issue on the project's GitHub repository for further assistance.

## License

This project is licensed under the MIT License. Please refer to the `LICENSE` file for more information.

## Acknowledgments

- This application was developed as a learning exercise and is not intended for production use.
- The game logic and structure were inspired by various online poker game implementations.
- Thanks to the open-source community for providing valuable resources and tools.