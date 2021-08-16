namespace TechZoneBgWebProject.Web.InputModels.ReplyReports
{
    using System.ComponentModel.DataAnnotations;

    using static TechZoneBgWebProject.Common.ErrorMessages;
    using static TechZoneBgWebProject.Common.GlobalConstants;

    public class ReplyReportsInputModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(Replies.ReplyReportDescriptionMaxLength, ErrorMessage = ReplyReportDescriptionLengthErrorMessage, MinimumLength = Replies.ReplyReportDescriptionMinLength)]
        public string Description { get; set; }
    }
}
