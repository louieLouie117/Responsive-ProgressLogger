using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProgressLog.Models
{

    public enum AccountType { Apprentice = 0, Mentor = 1, Admin = 2 }
    public class User
    {
        [Key]
        public int UserId { get; set; }

        // About User---------------------------

        public string UserTitle { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string UserMessage { get; set; }

        // address------------------------------
        public string City { get; set; }
        public string State { get; set; }

        // Users tools and technologies
        public string Languages { get; set; }
        public string Database { get; set; }
        public string VersionControl { get; set; }
        public string FrameworksLibraries { get; set; }

        // Profile-----------------------------
        [Column(TypeName = "nvarchar(24)")]
        [EnumDataType(typeof(AccountType))]
        public AccountType AccountType { get; set; }
        public string ProfileImg { get; set; }

        public string ProfileColor { get; set; }

        public string MeetUpLink { get; set; }
        public string MeetUpCost { get; set; }

        // email and password---------------------------
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

        // nav properties
        List<LogRecord> LogRecords { get; set; }

        List<Section> Sections { get; set; }

        List<UserSkill> UserSkills { get; set; }
        List<UserSpecialization> UserSpecializations { get; set; }



    }


}
