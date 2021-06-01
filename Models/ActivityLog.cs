using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgressLog.Models
{
    public class ActivityLog
    {
        [Key]
        public int ActivityLogId { get; set; }
        public string Title { get; set; }
        public string UrlLink { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // fKey for user
        public int UserId { get; set; }
        // navP
        public User User { get; set; }


        // f key for sections
        public int BookmarkCollectionId { get; set; }
        public BookmarkCollection BookmarkCollection { get; set; }



    }
}