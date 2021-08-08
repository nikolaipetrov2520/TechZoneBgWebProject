namespace TechZoneBgWebProject.Web.InputModels.Replais
{
    using System.ComponentModel.DataAnnotations;

    using static TechZoneBgWebProject.Common.GlobalConstants;

    public class RepliesEditInputModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(Replies.ReplyDescriptionMaxLength)]
        public string Description { get; set; }

        public string AuthorId { get; set; }
    }
}
