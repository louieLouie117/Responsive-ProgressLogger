using System;
using System.ComponentModel.DataAnnotations;

namespace ProgressLog.Models
{
    public class FollowerList
    {
        [Key]
        public int FollowerListId { get; set; }

        // id from user and Nav Property
        public int UserId { get; set; }
        public User User { get; set; }


        // Id From Follower and nav property
        public int FollowerId { get; set; }
        public Follower Follower { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;



    }
}