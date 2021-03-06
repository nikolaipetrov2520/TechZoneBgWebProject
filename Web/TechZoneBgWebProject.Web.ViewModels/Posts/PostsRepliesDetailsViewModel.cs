namespace TechZoneBgWebProject.Web.ViewModels.Posts
{
    using Ganss.XSS;

    using TechZoneBgWebProject.Common;

    public class PostsRepliesDetailsViewModel
    {
        private readonly IHtmlSanitizer sanitizer;

        public PostsRepliesDetailsViewModel()
        {
            this.sanitizer = new HtmlSanitizer();
            this.sanitizer.AllowedTags.Add(GlobalConstants.Sanitizer.IFrameTag);
        }

        public int Id { get; set; }

        public string Description { get; set; }

        public string SanitizedDescription
            => this.sanitizer.Sanitize(this.Description);

        public bool IsBestAnswer { get; set; }

        public int Likes { get; set; }

        public int Dislike { get; set; }

        public string CreatedOn { get; set; }

        public int? ParentId { get; set; }

        public string AuthorId { get; set; }

        public string AuthorFirstName { get; set; }

        public string AuthorLastName { get; set; }

        public string AuthorProfilePicture { get; set; }
    }
}
