namespace TechZoneBgWebProject.Web.InputModels.Tags
{
    using System.ComponentModel.DataAnnotations;

    using TechZoneBgWebProject.Web.Infrastructure.Attributes;

    using static TechZoneBgWebProject.Common.ErrorMessages;
    using static TechZoneBgWebProject.Common.GlobalConstants;

    public class TagsCreateInputModel
    {
        [Required]
        [StringLength(Tag.TagNameMaxLength, ErrorMessage = TagNameLengthErrorMessage, MinimumLength = Tag.TagNameMinLength)]
        [TagNameNotExists(ErrorMessage = TagExistingNameErrorMessage)]
        public string Name { get; set; }
    }
}
