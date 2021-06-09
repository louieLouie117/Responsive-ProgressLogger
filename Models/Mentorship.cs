using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProgressLog.Models
{
    public class Mentorship
    {
        [Key]
        public int MentorshipId { get; set; }

        [Display(Prompt = "new Mentorship..")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Day { get; set; }
        public string StartTime { get; set; }
        public string Duration { get; set; }
        public string EndTime { get; set; }

        public string AppointmentPrice { get; set; }
        public string AppointmentLink { get; set; }
        public string AppointmentBTNText { get; set; }
        public bool ShowAppointmentPricing { get; set; }


        public string EnrollmentLink { get; set; }
        public string EnrollmentDetails { get; set; }
        public string EnrollmentPrice { get; set; }
        public bool ShowEnrolmentBTN { get; set; }



        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        public int UserId { get; set; }
        // navP
        public User User { get; set; }

    }
}