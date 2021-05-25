using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProgressLog.Models
{
    public class Specialization
    {
        [Key]
        public int SpecializationId { get; set; }


        [Display(Prompt = "add specialization..")]
        public string SpecializationTitle { get; set; }

        public string SpecializationDescription { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        public int UserId { get; set; }
        // navP
        public User User { get; set; }


    }
}