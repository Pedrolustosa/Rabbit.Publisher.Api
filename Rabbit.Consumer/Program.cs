using System.Text;
using Rabbit.Models;
using RabbitMQ.Client;
using System.Text.Json;
using RabbitMQ.Client.Events;
using Rabbit.Models.Entities;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var factory = new ConnectionFactory { HostName = "localhost", UserName = "guest", Password = "guest" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "RabbitMessageQueue",
                     durable: false,
                     exclusive: false,
                     autoDelete: false,
                     arguments: null);

Console.WriteLine(" [*] Waiting for messages.");
var consumer = new EventingBasicConsumer(channel);
consumer.Received += (model, ea) =>
{
    var body = ea.Body.ToArray();
    var json = Encoding.UTF8.GetString(body);
    RabbitMessage rabbitMessage = JsonSerializer.Deserialize<RabbitMessage>(json) ?? new RabbitMessage();
    Thread.Sleep(1500);
    Console.WriteLine($"Id: {rabbitMessage.Id}, Title: {rabbitMessage.Title}, Text: {rabbitMessage.Text}");
};
channel.BasicConsume(queue: "RabbitMessageQueue",
                     autoAck: true,
                     consumer: consumer);

Console.WriteLine(" Press [enter] to exit.");
Console.ReadLine();