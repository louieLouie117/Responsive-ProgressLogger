using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProgressLog.Models
{
    public class ActivityCategory
    {
        [Key]
        public int ActivityCategoryId { get; set; }


        [Display(Prompt = "new Project..")]
        public string Title { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        // navP
        public User User { get; set; }


        List<ActivityLog> ActivityLogs { get; set; }

    }
}