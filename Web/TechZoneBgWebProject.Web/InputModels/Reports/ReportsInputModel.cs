namespace TechZoneBgWebProject.Web.InputModels.Reports
{
    using System.ComponentModel.DataAnnotations;

    using static TechZoneBgWebProject.Common.ErrorMessages;
    using static TechZoneBgWebProject.Common.GlobalConstants;

    public class ReportsInputModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(Post.PostReportDescriptionMaxLength, ErrorMessage = PostReportDescriptionLengthErrorMessage, MinimumLength = Post.PostReportDescriptionMinLength)]
        public string Description { get; set; }
    }
}
