namespace TechZoneBgWebProject.Web.ViewModels.Categories
{
    using System.Collections.Generic;

    using TechZoneBgWebProject.Web.ViewModels.Posts;

    public class CategoriesDetailsViewModel
    {
        public string Search { get; set; }

        public CategoriesInfoViewModel Category { get; set; }

        public IEnumerable<PostsListingViewModel> Posts { get; set; }
    }
}
