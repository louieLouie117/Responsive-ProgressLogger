using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgressLog.Models
{
    public class TodoListItem
    {
        [Key]
        public int TodoListItemId { get; set; }

        public string ItemText { get; set; }
        public string Description { get; set; }
        public string LabelColor { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // fKey for user
        public int UserId { get; set; }
        // navP
        public User User { get; set; }


        // f key for sections
        public int TodoListId { get; set; }
        public TodoList TodoList { get; set; }



    }
}