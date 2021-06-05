using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProgressLog.Models
{
    public class Connection
    {
        [Key]
        public int ConnectionId { get; set; }


        [Display(Prompt = "new Project..")]

        public string Name { get; set; }

        public string ProfileImage { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Kim: 5) This is a Foreign Key and implies a O2M or O2O relationship so there should be a reflection of that in User, either another key or middle table list
        public int UserId { get; set; }
        // navP
        public User User { get; set; }


        // Navigation property from association class M2M
        // Kim: 6)There should be a matching property in User.cs, middle table links the two outer tables, e.g. Collection -> CollectionList <- User
        List<ConnectionList> ConnectionLists { get; set; }

    }
}