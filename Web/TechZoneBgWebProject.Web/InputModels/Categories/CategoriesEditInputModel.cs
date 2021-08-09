namespace TechZoneBgWebProject.Web.InputModels.Categories
{
    using System.ComponentModel.DataAnnotations;

    using TechZoneBgWebProject.Web.Infrastructure.Attributes;

    using static TechZoneBgWebProject.Common.ErrorMessages;
    using static TechZoneBgWebProject.Common.GlobalConstants;

    public class CategoriesEditInputModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(Category.CategoryNameMaxLength, ErrorMessage = CategoryNameLengthErrorMessage, MinimumLength = Category.CategoryNameMinLength)]
        [CategoryNameNotExists(ErrorMessage = CategoryExistingNameErrorMessage)]
        public string Name { get; set; }
    }
}
