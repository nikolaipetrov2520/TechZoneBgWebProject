namespace TechZoneBgWebProject.Web.Hubs
{
    using System.Globalization;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.SignalR;

    using TechZoneBgWebProject.Common;
    using TechZoneBgWebProject.Services.Messages;
    using TechZoneBgWebProject.Services.Providers;
    using TechZoneBgWebProject.Services.Users;
    using TechZoneBgWebProject.Web.Infrastructure.Extensions;
    using TechZoneBgWebProject.Web.ViewModels.Messages;

    public class ChatHub : Hub
    {
        private readonly IUsersService usersService;
        private readonly IMessagesService messagesService;
        private readonly IDateTimeProvider dateTimeProvider;

        public ChatHub(
            IUsersService usersService,
            IMessagesService messagesService,
            IDateTimeProvider dateTimeProvider)
        {
            this.usersService = usersService;
            this.messagesService = messagesService;
            this.dateTimeProvider = dateTimeProvider;
        }

        public async Task WhoIsTyping(string name)
            => await this.Clients.Others.SendAsync("SayWhoIsTyping", name);

        public async Task SendMessage(string message, string receiverId)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                return;
            }

            var authorId = this.Context.User.GetId();
            var currentTime = this.dateTimeProvider.Now();
            var user = await this.usersService.GetByIdAsync<ChatUserViewModel>(authorId);

            await this.messagesService.CreateAsync(message, authorId, receiverId);
            await this.Clients.All.SendAsync(
                "ReceiveMessage",
                new ChatMessagesWithUserViewModel
                {
                    AuthorId = authorId,
                    AuthorFirstName = user.FirstName,
                    AuthorProfilePicture = user.ProfilePicture,
                    Content = message,
                    CreatedOn = currentTime.ToString(GlobalConstants.DateTime.DateTimeFormat, CultureInfo.InvariantCulture),
                });
        }
    }
}
