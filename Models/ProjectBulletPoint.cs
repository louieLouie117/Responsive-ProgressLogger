using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgressLog.Models
{
    public class ProjectBulletPoint
    {
        [Key]
        public int ProjectBulletPointId { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        // fKey for user
        public int UserId { get; set; }
        // navP
        public User User { get; set; }


        // f key for sections
        public int ProjectId { get; set; }
        public Project Project { get; set; }



    }
}