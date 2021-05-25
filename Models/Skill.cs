using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProgressLog.Models
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }


        [Display(Prompt = "new section..")]
        public string Title { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        public int UserId { get; set; }
        // navP
        public User User { get; set; }


    }
}