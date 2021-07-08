namespace TechZoneBgWebProject.Data.Models
{
    using System;

    using TechZoneBgWebProject.Data.Common.Models;

    public class Message : IAuditInfo, IDeletableEntity
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string AuthorId { get; set; }

        public ApplicationUser Author { get; set; }

        public string ReceiverId { get; set; }

        public ApplicationUser Receiver { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
