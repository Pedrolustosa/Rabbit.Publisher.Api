using System.Text;
using RabbitMQ.Client;
using System.Text.Json;
using Rabbit.Models.Entities;
using Rabbit.Repositories.Interfaces;

namespace Rabbit.Repositories.Repositories
{
    /// <summary>
    /// The rabbit message repository.
    /// </summary>
    public class RabbitMessageRepository : IRabbitMessageRepository
    {
        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="rabbitMessage">The rabbit message.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void SendMessage(RabbitMessage rabbitMessage)
        {
            // Obs: 'Using' ensures that the channel is closed properly after use.
            // Creating the Connection
            var factory = new ConnectionFactory() { HostName = "localhost", UserName = "guest", Password = "guest" };

            // Creating a RabbitMQ Connection Using the Connection Factory Instance
            using var connection = factory.CreateConnection();

            // Creating the channel
            using var channel = connection.CreateModel();

            // Creating Our Queue with certain configurations
            channel.QueueDeclare(queue: "RabbitMessageQueue",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            // Serialization of the rabbitMessage object to JSON format.
            string json = JsonSerializer.Serialize(rabbitMessage);

            // Conversion of the serialized JSON string to a UTF-8 byte array.
            var body = Encoding.UTF8.GetBytes(json);

            // Publish the message to the queue "RabbitMessageQueue" in the RabbitMQ channel
            channel.BasicPublish(exchange: "",
                                 routingKey: "RabbitMessageQueue",
                                 basicProperties: null,
                                 body: body);
        }
    }
}
