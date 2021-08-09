namespace TechZoneBgWebProject.Web.Infrastructure.Attributes
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.Extensions.DependencyInjection;

    using TechZoneBgWebProject.Services.Tags;

    public class TagNameNotExistsAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var tagsService = validationContext.GetService<ITagsService>();
            var isExisting = tagsService.IsExistingAsync((string)value).GetAwaiter().GetResult();
            if (isExisting)
            {
                return new ValidationResult(this.ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
