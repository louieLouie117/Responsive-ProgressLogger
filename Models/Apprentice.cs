using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProgressLog.Models
{
    public class Apprentice
    {
        [Key]
        public int ApprenticeId { get; set; }


        [Display(Prompt = "new Project..")]

        public string Name { get; set; }

        public string ProfileImage { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Kim: 3) This is a Foreign Key and implies a O2M or O2O relationship so there should be a reflection of that in User, either another key or middle table list
        public int UserId { get; set; }
        // navP
        public User User { get; set; }


        // Navigation property from association class M2M
        // Kim: 4)There should be a matching property in User.cs, middle table links the two outer tables, e.g. Apprentice -> ApprenticeList <- User
        List<ApprenticeList> ApprenticeLists { get; set; }

    }
}