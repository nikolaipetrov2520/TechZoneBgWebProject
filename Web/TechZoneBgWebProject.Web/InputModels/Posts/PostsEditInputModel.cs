namespace TechZoneBgWebProject.Web.InputModels.Posts
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using TechZoneBgWebProject.Web.Infrastructure.Attributes;
    using TechZoneBgWebProject.Web.ViewModels.Posts;

    using static TechZoneBgWebProject.Common.ErrorMessages;
    using static TechZoneBgWebProject.Common.GlobalConstants;

    public class PostsEditInputModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(Post.PostTitleMaxLength, ErrorMessage = PostTitleLengthErrorMessage, MinimumLength = Post.PostTitleMinLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(Post.PostDescriptionMaxLength)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [CategoryIdExists(ErrorMessage = CategoryNonExistingIdErrorMessage)]
        public int CategoryId { get; set; }

        public string AuthorId { get; set; }

        [TagIdsExists(ErrorMessage = TagNonExistingIdErrorMessage)]
        [Display(Name = Tag.TagsDisplayName)]
        public IEnumerable<int> TagIds { get; set; }

        public IEnumerable<PostsTagsDetailsViewModel> Tags { get; set; }

        public IEnumerable<PostsCategoryDetailsViewModel> Categories { get; set; }
    }
}
