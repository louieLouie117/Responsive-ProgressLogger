using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProgressLog.Models
{
    public class ChatMessage
    {
        [Key]
        public int ChatMessageId { get; set; }

        [Display(Prompt = "new section..")]

        public string Messsage { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        // navP
        public User User { get; set; }

        //needs nav prop for middle table


    }
}