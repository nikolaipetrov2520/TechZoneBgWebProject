﻿namespace TechZoneBgWebProject.Web.ViewModels.Orders
{
    using System.Collections.Generic;

    public class OrdersAllViewModel
    {
        public IEnumerable<OrdersListingViewModel> Carts { get; set; }

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
