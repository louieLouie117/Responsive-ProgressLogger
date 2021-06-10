using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProgressLog.Models
{
    public class Apprenticeship
    {
        [Key]
        public int ApprenticeshipId { get; set; }

        [Display(Prompt = "new Apprenticeship..")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string PurchaseLink { get; set; }
        public string PurchasePrice { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        public int UserId { get; set; }
        // navP
        public User User { get; set; }

        List<ApprenticeshipDetail> ApprenticeshipDetails { get; set; }


    }
}