namespace TechZoneBgWebProject.Web.InputModels.Replais
{
    using System.ComponentModel.DataAnnotations;

    using static TechZoneBgWebProject.Common.GlobalConstants;

    public class RepliesCreateInputModel
    {
        public int? ParentId { get; set; }

        [Required]
        public int PostId { get; set; }

        [Required]
        [MaxLength(Replies.ReplyDescriptionMaxLength)]
        public string Description { get; set; }
    }
}
