namespace TechZoneBgWebProject.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using TechZoneBgWebProject.Services.Messages;
    using TechZoneBgWebProject.Services.Users;
    using TechZoneBgWebProject.Web.Infrastructure.Extensions;
    using TechZoneBgWebProject.Web.InputModels.Chat;
    using TechZoneBgWebProject.Web.ViewModels.Messages;

    public class ChatController : Controller
    {
        private readonly IUsersService usersService;
        private readonly IMessagesService messagesService;

        public ChatController(IMessagesService messagesService, IUsersService usersService)
        {
            this.messagesService = messagesService;
            this.usersService = usersService;
        }

        public IActionResult All() => this.View();

        public async Task<IActionResult> SendMessage()
        {
            var viewModel = new ChatInputModel
            {
                Users = await this.usersService.GetAllAsync<ChatUserViewModel>(),
            };

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(ChatInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.Users = await this.usersService.GetAllAsync<ChatUserViewModel>();

                this.View(input);
            }

            await this.messagesService.CreateAsync(input.Message, this.User.GetId(), input.ReceiverId);

            return this.RedirectToAction(nameof(this.WithUser), new { id = input.ReceiverId });
        }

        public async Task<IActionResult> WithUser(string id)
        {
            var userId = this.User.GetId();
            var viewModel = new ChatWithUserViewModel
            {
                User = await this.usersService.GetByIdAsync<ChatUserViewModel>(id),
                Messages = await this.messagesService.GetAllWithUserAsync<ChatMessagesWithUserViewModel>(userId, id),
            };

            return this.View(viewModel);
        }
    }
}
