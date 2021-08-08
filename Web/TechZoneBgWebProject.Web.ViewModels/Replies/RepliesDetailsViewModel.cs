namespace TechZoneBgWebProject.Web.ViewModels.Replies
{
    using System.Collections.Generic;

    using Ganss.XSS;

    using TechZoneBgWebProject.Common;

    public class RepliesDetailsViewModel
    {
        private readonly IHtmlSanitizer sanitizer;

        public RepliesDetailsViewModel()
        {
            this.sanitizer = new HtmlSanitizer();
            this.sanitizer.AllowedTags.Add(GlobalConstants.Sanitizer.IFrameTag);
        }

        public int Id { get; set; }

        public string Description { get; set; }

        public string SanitizedDescription
            => this.sanitizer.Sanitize(this.Description);

        public int Likes { get; set; }

        public int Loves { get; set; }

        public int HahaCount { get; set; }

        public int WowCount { get; set; }

        public int SadCount { get; set; }

        public int AngryCount { get; set; }

        public string CreatedOn { get; set; }

        public int PostId { get; set; }

        public string PostAuthorId { get; set; }

        public int? ParentId { get; set; }

        public string AuthorId { get; set; }

        public string AuthorFirstName { get; set; }

        public string AuthorLastName { get; set; }

        public string AuthorProfilePicture { get; set; }

        public IEnumerable<RepliesDetailsViewModel> Replies { get; set; }
    }
}
