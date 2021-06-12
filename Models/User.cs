using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProgressLog.Models
{

    public enum AccountType { Apprentice = 0, Mentor = 1, Admin = 2, Lawyer = 3, Accountant = 4 }
    public class User
    {
        [Key]
        public int UserId { get; set; }

        // About User---------------------------
        public string UserName { get; set; }

        [MaxLength(25)]
        public string Title { get; set; }

        [MaxLength(25)]
        public string FirstName { get; set; }

        [MaxLength(25)]
        public string LastName { get; set; }
        [MaxLength(250)]
        public string UserMessage { get; set; }

        [MaxLength(250)]
        public string RoutineMessage { get; set; }

        [MaxLength(250)]
        public string ApprenticeshipDescription { get; set; }


        // Statues-----------------------------
        public bool IsOnline { get; set; }
        public bool IsTyping { get; set; }
        public bool ActiveOnChat { get; set; }
        public bool IsActive { get; set; }
        public int FollowersCount { get; set; }
        public int ApprenticesCount { get; set; }
        public int ConnectionsCount { get; set; }
        public int PortfolioViewCount { get; set; }
        public int MaxApprentices { get; set; }

        // address------------------------------
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(25)]
        public string State { get; set; }

        // Users tools and technologies
        [MaxLength(250)]
        public string Languages { get; set; }

        [MaxLength(250)]
        public string Database { get; set; }

        [MaxLength(250)]
        public string VersionControl { get; set; }

        [MaxLength(250)]
        public string FrameworksLibraries { get; set; }

        // Profile-----------------------------
        [Column(TypeName = "nvarchar(24)")]
        [EnumDataType(typeof(AccountType))]
        public AccountType AccountType { get; set; }
        public string ProfileImg { get; set; }
        public string ProfileColor { get; set; }
        public string FontType { get; set; }

        // email and password---------------------------
        [EmailAddress]
        [Required]
        [MaxLength(100)]
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

        // nav properties for Daily Journal-------------------------
        List<LogRecord> LogRecords { get; set; }
        List<Section> Sections { get; set; }

        // nav properties for Activity Tracker------------------------------------------------
        List<ActivityCategory> ActivityCategorys { get; set; }
        List<ActivityLog> ActivityLogs { get; set; }

        // nav properties for Appretice------------------------------------------------
        List<Apprentice> Apprentices { get; set; }
        List<ApprenticeList> ApprenticeLists { get; set; }

        // nav properties for Booksmakes------------------------------------------------
        List<BookmarkCollection> BookmarkCollections { get; set; }
        List<Bookmark> Bookmarks { get; set; }


        // nav properties for Connections------------------------------------------------
        List<Connection> Connections { get; set; }
        List<ConnectionList> ConnectionLists { get; set; }


        // nav properties for DailyRoutine------------------------------------------------
        List<DailyRoutine> DailyRoutines { get; set; }

        // nav properties for Followers------------------------------------------------
        List<FollowerList> FollowerLists { get; set; }
        List<Follower> Followers { get; set; }

        // nav properties for Job Tracker------------------------------------------------
        List<JobTracker> JobTrackers { get; set; }
        List<JobTrackerNote> JobTrackerNotes { get; set; }

        // nav properties for Post------------------------------------------------
        List<Post> Posts { get; set; }
        List<PostComment> PostComments { get; set; }

        // nav properties for Projects-----------------------------------------
        List<Project> Projects { get; set; }
        List<ProjectTool> ProjectTools { get; set; }
        List<ProjectBulletPoint> ProjectBulletPoints { get; set; }


        // nav properties for Skills---------------------------------
        List<Skill> Skills { get; set; }
        List<Specialization> Specializations { get; set; }

        // nav properties for Stickynotes-----------------------------------------------
        List<StickyNoteCollection> StickyNoteCollections { get; set; }
        List<StickyNote> StickyNotes { get; set; }

        // nav properties for Todo list-----------------------------------------------
        List<TodoList> TodoLists { get; set; }
        List<TodoListItem> TodoListItems { get; set; }


        // nav properties for External Link-----------------------------------------------
        List<ExternalLink> ExternalLinks { get; set; }

        // nav properties for Mentership-----------------------------------------------
        List<Mentorship> Mentorships { get; set; }
        List<MentorshipTopic> MentorshipTopics { get; set; }


        // nav properties for Apprenticeship-----------------------------------------------
        List<Apprenticeship> Apprenticeships { get; set; }
        List<ApprenticeshipDetail> ApprenticeshipDetails { get; set; }


        // nav properties for chatRoom -----------------------------------------------
        List<ChatRoom> ChatRooms { get; set; } // switch: this is the one side in the O2M
        // nav properties for ChatRoomHasMessages-----------------------------------------------
        List<ChatRoomHasMessage> ChatRoomHasMessages { get; set; }
        // nav properties for CharMessages-----------------------------------------------
        List<ChatMessage> ChatMessages { get; set; }

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
