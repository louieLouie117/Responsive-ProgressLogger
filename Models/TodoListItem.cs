using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgressLog.Models
{

    public enum PriorityType { Urgent = 0, Timely = 1, RelativelySoon = 2, DownTheLine = 3 }

    public class TodoListItem
    {
        [Key]
        public int TodoListItemId { get; set; }

        public string ItemText { get; set; }
        public string Description { get; set; }
        public string LabelColor { get; set; }

        [Column(TypeName = "nvarchar(24)")]
        [EnumDataType(typeof(AccountType))]
        public PriorityType PriorityType { get; set; }

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