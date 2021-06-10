using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgressLog.Models
{
    public class ApprenticeshipDetail
    {
        [Key]
        public int ApprenticeshipDetailId { get; set; }

        public string Description { get; set; }
        public int Pricing { get; set; }

        public bool HasSubscription { get; set; }
        public bool SubscriptionMessage { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        // fKey for user
        public int UserId { get; set; }
        // navP
        public User User { get; set; }


        // f key for sections
        public int ApprenticeshipId { get; set; }
        public Apprenticeship Apprenticeship { get; set; }



    }
}