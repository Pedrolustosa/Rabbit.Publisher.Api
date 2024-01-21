using Rabbit.Models.Entities;
using Rabbit.Service.Interfaces;
using Rabbit.Repositories.Interfaces;

namespace Rabbit.Service
{
    /// <summary>
    /// The rabbit message service.
    /// </summary>
    public class RabbitMessageService : IRabbitMessageService
    {
        /// <summary>
        /// The repository.
        /// </summary>
        private readonly IRabbitMessageRepository _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="RabbitMessageService"/> class.
        /// </summary>
        /// <param name="rabbitMessageRepository">The rabbit message repository.</param>
        public RabbitMessageService(IRabbitMessageRepository rabbitMessageRepository)
        {
            _repository = rabbitMessageRepository;
        }

        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="rabbitMessage">The rabbit message.</param>
        public void SendMessage(RabbitMessage rabbitMessage)
        {
            _repository.SendMessage(rabbitMessage);
        }
    }
}
