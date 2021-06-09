using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProgressLog.Models
{
    public class ChatRoom
    {
        [Key]
        public int ChatRoomId { get; set; }

        [Display(Prompt = "new section..")]

        public string ChatRoomFor { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


// switch: this is the many side
        public int UserId { get; set; }
        // navP
        public User User { get; set; }

        //add list of ChatMessages


    }
}