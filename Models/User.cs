using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProgressLog.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Display]
        [Required(ErrorMessage = "Can not be empty")]
        [MinLength(2, ErrorMessage = "That is to short")]
        public string FirstName { get; set; }


        [Display]
        [Required(ErrorMessage = "Can not be empty")]
        [MinLength(2, ErrorMessage = "That is to short")]
        public string LastName { get; set; }


        [Display]
        [EmailAddress]
        [Required]
        public string Email { get; set; }


        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        // Will not be mapped to your users table!
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm { get; set; }

        // nav propertys
        List<LogRecord> LogRecords { get; set; }

        List<Section> Sections { get; set; }

    }


}
