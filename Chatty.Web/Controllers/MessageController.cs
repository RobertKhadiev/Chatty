using Chatty.Domain.Interfaces;
using Chatty.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Chatty.Web.Controllers
{
    [Route("api/messages")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet("{chatId}")]
        public IActionResult GetMessagesByChatId(long chatId)
        {
            var messages = _messageService.GetMessagesByChatId(chatId);

            return Ok(messages);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(MessageDto messageDto)
        {
            var messageId = await _messageService.CreateMessage(messageDto);
            return Ok(messageId);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMessage(long id, MessageDto messageDto)
        {
            await _messageService.UpdateMessage(id, messageDto);
            return Ok();
        }
    }
}