# Simple TCP Server and Client
This project consists of a simple TCP server and client written in C#. It demonstrates basic socket programming concepts, allowing the server to receive messages from the client and respond with a confirmation message.

# Getting Started
## Prerequisites
.NET Framework
Visual Studio or any C# IDE
Running the Server
Navigate to the TcpServer project directory.
Build and run the project.
The server will listen on 127.0.0.1:8080 and wait for incoming connections.
Running the Client
Navigate to the TcpClient project directory.
Build and run the project.
Enter a message when prompted, which will be sent to the server.
Communication Flow
The client sends a message to the server.
The server receives the message and prints it to the console.
The server responds with a confirmation message: "successfully!"
The client receives and displays the server's response.
Code Structure
TcpServer: Contains the server-side implementation.
TcpClient: Contains the client-side implementation.
License
This project is licensed under the MIT License - see the LICENSE file for details.

Acknowledgments
Inspired by basic socket programming tutorials and examples.

Feel free to modify this description to better fit your project's specifics or style!
