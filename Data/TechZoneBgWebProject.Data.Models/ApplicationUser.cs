namespace TechZoneBgWebProject.Data.Models
{
    using System;
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Identity;

    using TechZoneBgWebProject.Data.Common.Models;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
        }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Points { get; set; }

        public string Address { get; set; }

        public string ProfilePicture { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool IsModified { get; set; }

        public ICollection<Message> SentMessages { get; set; } = new HashSet<Message>();

        public ICollection<Cart> Carts { get; set; } = new HashSet<Cart>();

        public ICollection<Message> ReceivedMessages { get; set; } = new HashSet<Message>();

        public ICollection<Post> Posts { get; set; } = new HashSet<Post>();

        public ICollection<Reply> Replies { get; set; } = new HashSet<Reply>();

        public ICollection<PostReaction> PostReactions { get; set; } = new HashSet<PostReaction>();

        public ICollection<PostReport> PostReports { get; set; } = new HashSet<PostReport>();

        public ICollection<ReplyReaction> ReplyReactions { get; set; } = new HashSet<ReplyReaction>();

        public ICollection<ReplyReport> ReplyReports { get; set; } = new HashSet<ReplyReport>();

        public ICollection<UserFollower> Followers { get; set; } = new HashSet<UserFollower>();

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; } = new HashSet<IdentityUserRole<string>>();

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; } = new HashSet<IdentityUserClaim<string>>();

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; } = new HashSet<IdentityUserLogin<string>>();
    }
}
