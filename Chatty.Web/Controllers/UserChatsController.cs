using Chatty.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Chatty.Web.Controllers
{
    [Route("api/user-chats")]
    [ApiController]
    public class UserChatsController : ControllerBase
    {
        private readonly IUserChatsService _userChatsService;

        public UserChatsController(IUserChatsService userChatsService)
        {
            _userChatsService = userChatsService;
        }

        [HttpGet("{userId}")]
        public IActionResult GetChatsByUserId(long userId)
        {
            var chats = _userChatsService.GetChatsByUser(userId);

            return Ok(chats);
        }
    }
}