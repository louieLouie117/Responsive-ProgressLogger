using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProgressLog.Models
{
    public class Follower
    {
        [Key]
        public int FollowerId { get; set; }


        [Display(Prompt = "new Project..")]

        public string Name { get; set; }

        public string ProfileImage { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        // navP
        public User User { get; set; }



        // Navigation property from association class M2M
        List<FollowerList> FollowerLists { get; set; }

    }
}