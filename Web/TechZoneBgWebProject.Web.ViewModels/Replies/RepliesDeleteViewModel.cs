namespace TechZoneBgWebProject.Web.ViewModels.Replies
{
    using Ganss.XSS;

    using TechZoneBgWebProject.Common;

    public class RepliesDeleteViewModel
    {
        private readonly IHtmlSanitizer sanitizer;

        public RepliesDeleteViewModel()
        {
            this.sanitizer = new HtmlSanitizer();
            this.sanitizer.AllowedTags.Add(GlobalConstants.Sanitizer.IFrameTag);
        }

        public int Id { get; set; }

        public string Description { get; set; }

        public string SanitizedDescription
            => this.sanitizer.Sanitize(this.Description);

        public int Likes { get; set; }

        public int Dislike { get; set; }

        public string CreatedOn { get; set; }

        public string AuthorId { get; set; }

        public string AuthorFirstName { get; set; }

        public string AuthorLastName { get; set; }

        public string AuthorProfilePicture { get; set; }
    }
}
