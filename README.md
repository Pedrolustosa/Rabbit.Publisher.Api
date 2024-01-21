# RabbitMQ Study Project

[![License](https://img.shields.io/github/license/Pedrolustosa/Rabbit.Publisher.Api?style=for-the-badge)](https://github.com/Pedrolustosa/Rabbit.Publisher.Api/blob/main/LICENSE)
[![GitHub issues](https://img.shields.io/github/issues/Pedrolustosa/Rabbit.Publisher.Api?style=for-the-badge)](https://github.com/Pedrolustosa/Rabbit.Publisher.Api/issues)
[![GitHub stars](https://img.shields.io/github/stars/Pedrolustosa/Rabbit.Publisher.Api?style=for-the-badge)](https://github.com/Pedrolustosa/Rabbit.Publisher.Api/stargazers)
[![Views](https://img.shields.io/badge/dynamic/json?color=blue&label=views&query=%24.views&url=https%3A%2F%2Fapi.github.com%2Frepos%2FPedrolustosa%2FRabbit.Publisher.Api&style=for-the-badge)](https://github.com/Pedrolustosa/Rabbit.Publisher.Api)

This is a simple project created for studying the RabbitMQ functionality using the C# language and .NET 6.

## Project Structure

The project is organized into different modules to facilitate understanding and maintenance. Here's an overview of the structure:

- **Rabbit.Consumer**: Module responsible for consuming messages from RabbitMQ.
- **Rabbit.Models**: Definition of data models (entities) used in the project.
- **Rabbit.Publisher.Api**: API responsible for publishing messages to RabbitMQ.
- **Rabbit.Repositories**: Interfaces and implementations of repositories for storing or retrieving data related to RabbitMQ messages.
- **Rabbit.Service**: Interfaces and implementations of services for processing or handling RabbitMQ messages.

## Dependencies

- [.NET 6](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Docker](https://www.docker.com/get-started) (for RabbitMQ)
- [RabbitMQ](https://www.rabbitmq.com/)
  
## Configuration and Usage

1. **Clone the Repository**:
    ```bash
    git clone https://github.com/Pedrolustosa/Rabbit.Publisher.Api.git
    ```

2. **Install Docker and RabbitMQ**:
    - Make sure you have [Docker](https://www.docker.com/get-started) installed on your machine.
    - Pull the RabbitMQ Docker image:

    ```bash
    docker pull rabbitmq
    ```

3. **Run RabbitMQ Container**:
    - Start a RabbitMQ container with the following command:

    ```bash
    docker run -d --name rabbitmq-container -p 5672:5672 -p 15672:15672 rabbitmq
    ```

    This will run RabbitMQ on port 5672 and expose the management interface on port 15672.

4. **RabbitMQ Configuration**:
    - Update the RabbitMQ connection settings in the code as needed to match your Docker container.

5. **Run the Project**:
    - Open the project in Visual Studio or use .NET CLI commands to run the project.

    ```bash
    cd Rabbit.Publisher.Api
    dotnet run
    ```

6. **Test the API**:
    - Use tools like [Postman](https://www.postman.com/) to send requests to the API and observe the sending of RabbitMQ messages.

## Contributions

Contributions are welcome! Feel free to open issues or send pull requests.

## License

This project is licensed under the [MIT License](https://github.com/Pedrolustosa/Rabbit.Publisher.Api/blob/main/LICENSE).
