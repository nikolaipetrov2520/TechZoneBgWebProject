namespace TechZoneBgWebProject.Web.ViewModels.Orders
{
    using System;

    public class OrdersListingViewModel
    {
        public int Id { get; set; }

        public string PhoneNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Time { get; set; }

        public string Comment { get; set; }

        public decimal Sum { get; set; }

    }
}
