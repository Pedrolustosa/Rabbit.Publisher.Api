using Rabbit.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Rabbit.Service.Interfaces;

namespace Rabbit.Publisher.Api.Controllers
{
    /// <summary>
    /// The rabbit messages controller.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class RabbitMessagesController : Controller
    {
        /// <summary>
        /// The service.
        /// </summary>
        private readonly IRabbitMessageService _service;

        /// <summary>
        /// Initializes a new instance of the <see cref="RabbitMessagesController"/> class.
        /// </summary>
        /// <param name="rabbitMessageService">The rabbit message service.</param>
        public RabbitMessagesController(IRabbitMessageService rabbitMessageService)
        {
            _service = rabbitMessageService;
        }

        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="rabbitMessage">The rabbit message.</param>
        [HttpPost]
        public void SendMessage(RabbitMessage rabbitMessage)
        {
            _service.SendMessage(rabbitMessage);
        }
    }
}
