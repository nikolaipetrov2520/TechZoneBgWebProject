namespace TechZoneBgWebProject.Data.Models
{
    using System;

    using TechZoneBgWebProject.Data.Common.Models;

    public class UserFollower : IAuditInfo, IDeletableEntity
    {
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string FollowerId { get; set; }

        public ApplicationUser Follower { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
