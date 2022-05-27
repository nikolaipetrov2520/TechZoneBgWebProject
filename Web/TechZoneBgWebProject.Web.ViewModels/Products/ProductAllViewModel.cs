namespace TechZoneBgWebProject.Web.ViewModels.Products
{
    using System.Collections.Generic;

    public class ProductAllViewModel
    {
        public IEnumerable<ProductsListingViewModel> Products { get; set; }

        public string Search { get; set; }

        public string Sort{ get; set; }

        public int PageIndex { get; set; }

        public int TotalPages { get; set; }

        public int NextPage
        {
            get
            {
                if (this.PageIndex >= this.TotalPages)
                {
                    return 1;
                }

                return this.PageIndex + 1;
            }
        }

        public int PreviousPage
        {
            get
            {
                if (this.PageIndex <= 1)
                {
                    return this.TotalPages;
                }

                return this.PageIndex - 1;
            }
        }
    }
}
