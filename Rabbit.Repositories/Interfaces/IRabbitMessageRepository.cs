using Rabbit.Models.Entities;

namespace Rabbit.Repositories.Interfaces
{
    /// <summary>
    /// The rabbit message repository interface.
    /// </summary>
    public interface IRabbitMessageRepository
    {
        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="rabbitMessage">The rabbit message.</param>
        void SendMessage(RabbitMessage rabbitMessage);
    }
}
