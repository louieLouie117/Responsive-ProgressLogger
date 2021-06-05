using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgressLog.Models
{
    public class JobTrackerNote
    {
        [Key]
        public int JobTrackerNoteId { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // fKey for user
        public int UserId { get; set; }
        // navP
        public User User { get; set; }


        // f key for sections
        public int JobTrackerId { get; set; }
        public JobTracker JobTracker { get; set; }



    }
}