namespace TechZoneBgWebProject.Web.Components
{
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using TechZoneBgWebProject.Services.Messages;
    using TechZoneBgWebProject.Web.Infrastructure.Extensions;
    using TechZoneBgWebProject.Web.ViewModels.Messages;

    [ViewComponent(Name = "Chat")]
    public class ChatViewComponent : ViewComponent
    {
        private readonly IMessagesService messagesService;

        public ChatViewComponent(IMessagesService messagesService)
            => this.messagesService = messagesService;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var currentUserId = this.UserClaimsPrincipal.GetId();
            var conversations = await this.messagesService.GetAllAsync<ChatViewModel>(currentUserId);

            foreach (var user in conversations)
            {
                user.LastMessage = await this.messagesService.GetLastMessageAsync(currentUserId, user.Id);
                user.LastMessageActivity = await this.messagesService.GetLastActivityAsync(currentUserId, user.Id);
            }

            conversations = conversations.OrderByDescending(x => x.LastMessageActivity);

            return this.View(conversations);
        }
    }
}
