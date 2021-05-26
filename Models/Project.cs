using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProgressLog.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }


        [Display(Prompt = "new Project..")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public string ButtonColor { get; set; }
        public string ButtonText { get; set; }
        public string Likes { get; set; }



        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;



        public int UserId { get; set; }
        // navP
        public User User { get; set; }


        List<ProjectTool> ProjectTools { get; set; }

    }
}