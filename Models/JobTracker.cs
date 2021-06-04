using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProgressLog.Models
{

    public enum Status { Applied = 0, Denied = 1, Called = 2, Interview = 3 }

    public class JobTracker
    {
        [Key]
        public int PostId { get; set; }

        [Display(Prompt = "new message..")]

        public string Company { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }

        public string CoverLetter { get; set; }

        [EnumDataType(typeof(Status))]
        public Status Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        // navP
        public User User { get; set; }

        List<JobTrackerNote> JobTrackerNotes { get; set; }


    }
}