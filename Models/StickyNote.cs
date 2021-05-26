using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgressLog.Models
{
    public class StickyNote
    {
        [Key]
        public int StickyNoteId { get; set; }

        public string Text { get; set; }
        public string PositionX { get; set; }
        public string PositionY { get; set; }
        public string Color { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // fKey for user
        public int UserId { get; set; }
        // navP
        public User User { get; set; }


        // f key for sections
        public int StickyNoteCollectionId { get; set; }
        public StickyNoteCollection StickyNoteCollection { get; set; }



    }
}