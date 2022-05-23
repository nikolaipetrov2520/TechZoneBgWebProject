namespace TechZoneBgWebProject.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Cart
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public ICollection<CartProduct> Products { get; set; } = new HashSet<CartProduct>();

        public string AuthorId { get; set; }

        public ApplicationUser Author { get; set; }

        public string Address { get; set; }

        public bool IsFinished { get; set; }

        public bool IsOrdered { get; set; }

        public bool IsSend { get; set; }

        public string Comment { get; set; }
    }
}
