using Microsoft.EntityFrameworkCore;

namespace ProgressLog.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }


        public DbSet<User> Users { get; set; }

        public DbSet<Section> Sections { get; set; }
        public DbSet<LogRecord> LogRecords { get; set; }



        public DbSet<Skill> Skills { get; set; }
        public DbSet<Specialization> Specializations { get; set; }



        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTool> ProjectTools { get; set; }
        public DbSet<ProjectBulletPoint> ProjectBulletPoints { get; set; }




        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<TodoListItem> TodoListItems { get; set; }



        public DbSet<StickyNoteCollection> StickyNoteCollections { get; set; }
        public DbSet<StickyNote> StickyNotes { get; set; }



        public DbSet<BookmarkCollection> BookmarkCollections { get; set; }
        public DbSet<Bookmark> Bookmarks { get; set; }


        public DbSet<ActivityCategory> ActivityCategorys { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }



        public DbSet<Post> Posts { get; set; }
        public DbSet<PostComment> PostComments { get; set; }



        public DbSet<JobTracker> JobTrackers { get; set; }
        public DbSet<JobTrackerNote> JobTrackerNotes { get; set; }



        public DbSet<Follower> Followers { get; set; }

        public DbSet<FollowerList> FollowerLists { get; set; }

        public DbSet<Apprentice> Apprentices { get; set; }
        public DbSet<ApprenticeList> ApprenticeLists { get; set; }



        public DbSet<Connection> Connections { get; set; }
        public DbSet<ConnectionList> ConnectionLists { get; set; }

        public DbSet<DailyRoutine> DailyRoutines { get; set; }

        public DbSet<ExternalLink> ExternalLinks { get; set; }

        public DbSet<Mentorship> Mentorships { get; set; }
        public DbSet<MentorshipTopic> MentorshipTopics { get; set; }


        public DbSet<Apprenticeship> Apprenticeships { get; set; }
        public DbSet<ApprenticeshipDetail> ApprenticeshipDetails { get; set; }




        public DbSet<ChatRoom> ChatRooms { get; set; }
        public DbSet<ChatRoomHasMessage> ChatRoomHasMessages { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }












    }
}