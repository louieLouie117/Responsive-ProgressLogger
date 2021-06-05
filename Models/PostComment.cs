using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProgressLog.Models
{
    public class PostComment
    {
        [Key]
        public int PostCommentId { get; set; }


        [Display(Prompt = "new message..")]
        public string Message { get; set; }
        public string ImageLink { get; set; }
        public string VideoLink { get; set; }
        public int LikesCount { get; set; }
        public int CelebratesCount { get; set; }
        public int HeartsCount { get; set; }
        public int SupportsCount { get; set; }
        public int SharesCount { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        // navP
        public User User { get; set; }


        // f key for sections
        public int PostId { get; set; }
        public Post Post { get; set; }

    }
}