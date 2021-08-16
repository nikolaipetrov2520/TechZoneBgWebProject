namespace TechZoneBgWebProject.Web.ViewModels.Reports
{
    using Ganss.XSS;

    using TechZoneBgWebProject.Common;

    public class PostReportsListingViewModel
    {
        private readonly IHtmlSanitizer sanitizer;

        public PostReportsListingViewModel()
        {
            this.sanitizer = new HtmlSanitizer();
            this.sanitizer.AllowedTags.Add(GlobalConstants.Sanitizer.IFrameTag);
        }

        public int Id { get; set; }

        public string Description { get; set; }

        public string ShortDescription
        {
            get
            {
                var sanitized = this.sanitizer.Sanitize(this.Description);

                return this.Description.Length > GlobalConstants.Reports.ShortDescriptionAllowedLength
                   ? sanitized.Substring(0, GlobalConstants.Reports.ShortDescriptionAllowedLength) + "..."
                   : sanitized;
            }
        }

        public string CreatedOn { get; set; }

        public string PostTitle { get; set; }

        public string AuthorFirstName { get; set; }

        public string AuthorLastName { get; set; }

        public string AuthorProfilePicture { get; set; }
    }
}
