using Rabbit.Models.Entities;

namespace Rabbit.Service.Interfaces
{
    /// <summary>
    /// The rabbit message service interface.
    /// </summary>
    public interface IRabbitMessageService
    {
        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="rabbitMessage">The rabbit message.</param>
        void SendMessage(RabbitMessage rabbitMessage);
    }
}
