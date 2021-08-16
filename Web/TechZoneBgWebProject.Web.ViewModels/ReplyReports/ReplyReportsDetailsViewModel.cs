namespace TechZoneBgWebProject.Web.ViewModels.ReplyReports
{
    using Ganss.XSS;

    using TechZoneBgWebProject.Common;

    public class ReplyReportsDetailsViewModel
    {
        private readonly IHtmlSanitizer sanitizer;

        public ReplyReportsDetailsViewModel()
        {
            this.sanitizer = new HtmlSanitizer();
            this.sanitizer.AllowedTags.Add(GlobalConstants.Sanitizer.IFrameTag);
        }

        public int Id { get; set; }

        public string Description { get; set; }

        public string SanitizedDescription
            => this.sanitizer.Sanitize(this.Description);

        public string CreatedOn { get; set; }

        public string AuthorId { get; set; }

        public string AuthorFirstName { get; set; }

        public string AuthorLastName { get; set; }

        public string AuthorProfilePicture { get; set; }

        public int ReplyId { get; set; }

        public string ReplyDescription { get; set; }

        public string SanitizedReplyDescription
            => this.sanitizer.Sanitize(this.ReplyDescription);
    }
}
