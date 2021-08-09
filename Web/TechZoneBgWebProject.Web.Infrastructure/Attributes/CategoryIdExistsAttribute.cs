﻿namespace TechZoneBgWebProject.Web.Infrastructure.Attributes
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.Extensions.DependencyInjection;

    using TechZoneBgWebProject.Services.Categories;

    public class CategoryIdExistsAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var categoriesService = validationContext.GetService<ICategoriesService>();
            var isExisting = categoriesService.IsExistingAsync((int)value).GetAwaiter().GetResult();
            if (!isExisting)
            {
                return new ValidationResult(this.ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
