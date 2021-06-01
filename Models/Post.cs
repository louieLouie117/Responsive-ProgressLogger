using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProgressLog.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Display(Prompt = "new message..")]
        public string Message { get; set; }
        public string ImageLink { get; set; }
        public string VideoLink { get; set; }
        public int Likes { get; set; }
        public int Celebrates { get; set; }
        public int Hearts { get; set; }
        public int Supports { get; set; }
        public string Shares { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        // navP
        public User User { get; set; }


        List<PostComment> PostComments { get; set; }

    }
}