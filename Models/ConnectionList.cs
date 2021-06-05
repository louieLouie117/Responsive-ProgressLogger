using System;
using System.ComponentModel.DataAnnotations;

namespace ProgressLog.Models
{
    public class ConnectionList
    {
        [Key]
        public int ConnectionListId { get; set; }

        // id from user and Nav Property
        public int UserId { get; set; }
        public User User { get; set; }


        // Id From Connection and nav property
        public int ConnectionId { get; set; }
        public Connection Connection { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;



    }
}