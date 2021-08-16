namespace TechZoneBgWebProject.Web.ViewModels.Reports
{
    using Ganss.XSS;

    using TechZoneBgWebProject.Common;

    public class PostReportsDetailsViewModel
    {
        private readonly IHtmlSanitizer sanitizer;

        public PostReportsDetailsViewModel()
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

        public int PostId { get; set; }

        public string PostTitle { get; set; }
    }
}
