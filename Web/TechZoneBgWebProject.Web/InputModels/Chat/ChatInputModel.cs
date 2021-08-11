namespace TechZoneBgWebProject.Web.InputModels.Chat
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using TechZoneBgWebProject.Web.ViewModels.Messages;

    using static TechZoneBgWebProject.Common.GlobalConstants;

    public class ChatInputModel
    {
        [Required]
        [MaxLength(Messages.MessageContentMaxLength)]
        public string Message { get; set; }

        [Required]
        public string ReceiverId { get; set; }

        public IEnumerable<ChatUserViewModel> Users { get; set; }
    }
}
