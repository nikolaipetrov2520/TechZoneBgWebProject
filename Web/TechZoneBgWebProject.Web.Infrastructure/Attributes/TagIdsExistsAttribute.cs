﻿namespace TechZoneBgWebProject.Web.Infrastructure.Attributes
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.Extensions.DependencyInjection;

    using TechZoneBgWebProject.Common;
    using TechZoneBgWebProject.Services.Tags;

    public class TagIdsExistsAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!(value is IEnumerable<int> collection))
            {
                return new ValidationResult(ErrorMessages.TagIsRequiredErrorMessage);
            }

            var tagsService = validationContext.GetService<ITagsService>();
            var areExisting = tagsService.AreExistingAsync(collection).GetAwaiter().GetResult();
            if (!areExisting)
            {
                return new ValidationResult(this.ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
