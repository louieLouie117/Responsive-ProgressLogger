using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProgressLog.Models
{
    public class StickyNoteCollection
    {
        [Key]
        public int StickyNoteCollectionId { get; set; }


        [Display(Prompt = "new Project..")]
        public string Title { get; set; }

        public string Color { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        // navP
        public User User { get; set; }


        List<StickyNote> StickyNotes { get; set; }

    }
}