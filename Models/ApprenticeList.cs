using System;
using System.ComponentModel.DataAnnotations;

namespace ProgressLog.Models
{
    public class ApprenticeList
    {
        [Key]
        public int ApprenticeListId { get; set; }

        // id from user and Nav Property
        public int UserId { get; set; }
        public User User { get; set; }


        // Id From Apprentice and nav property
        public int ApprenticeId { get; set; }
        public Apprentice Apprentice { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;



    }
}