using System;
using System.ComponentModel.DataAnnotations;

namespace ProgressLog.Models
{
    public class ChatRoomHasMessage
    {
        [Key]
        public int ChatRoomHasMessageId { get; set; }

        // id from user and Nav Property
        public int ChatRoomId { get; set; }
        public ChatRoom ChatRoom { get; set; }


        // Id From Follower and nav property
        public int ChatMessageId { get; set; }
        public ChatMessage ChatMessage { get; set; }


        public int UserId { get; set; } //remove?
        // navP
        public User User { get; set; } //remove?

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;



    }
}