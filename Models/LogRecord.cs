using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgressLog.Models
{
    public class LogRecord
    {
        [Key]
        public int LogRecordId { get; set; }

        [MaxLength(5000)]
        public string TextLog { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        // fKey for user
        public int UserId { get; set; }
        // navP
        public User User { get; set; }


        // f key for sections
        public int SectionId { get; set; }
        public Section Section { get; set; }



    }
}