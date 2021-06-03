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
        public string UserName { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string UserMessage { get; set; }

        // Statues-----------------------------
        public bool IsOnline { get; set; }
        public bool IsActive { get; set; }
        public int Followers { get; set; }
        public int Apprentices { get; set; }
        public int Connections { get; set; }


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

        List<Skill> Skills { get; set; }
        List<Specialization> Specializations { get; set; }

        List<Project> Projects { get; set; }
        List<ProjectTool> ProjectTools { get; set; }

        List<StickyNoteCollection> StickyNoteCollections { get; set; }

        List<StickyNote> StickyNotes { get; set; }

        // Kim: 1) The other end of the O2M/O2O for Follower,  e.g. Follower  <- User
        // List<Follower> {Name} { get; set; } O2M
        // Follower {Name} { get; set; } O2O

        // Kim: 2) The other end of the M2M for Follower,  e.g. Follower -> FollowerList <- User
        // List<FollowerList> {Name} { get; set; } M2M

        // Kim: 3) The other end of the O2M/O2O for Apprentice,  e.g. Apprentice  <- User
        // List<Apprentice> {Name} { get; set; } O2M
        // Apprentice {Name} { get; set; } O2O

        // Kim: 4) The other end of the M2M for Apprentice,  e.g. Apprentice -> ApprenticeList <- User
        // List<ApprenticeList> {Name} { get; set; } M2M

        // Kim: 5) The other end of the O2M/O2O for Collection,  e.g. Collection  <- User
        // List<Collection> {Name} { get; set; } O2M
        // Collection {Name} { get; set; } O2O

        // Kim: 6) The other end of the M2M for Collection,  e.g. Collection -> CollectionList <- User
        // List<CollectionList> {Name} { get; set; } M2M

    }


}
