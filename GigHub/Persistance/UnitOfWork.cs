using GigHub.Core;
using GigHub.Core.Repositories;
using GigHub.Persistance.Repositories;

namespace GigHub.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
   
        public IGigRepository Gigs { get; private set; }
        public IGenreRepository Genres { get; private set; }
        public IAttendanceRepository Attendances { get; set; }
        public IFollowingRepository Followings { get; set; }
        public IApplicationUserRepository Users { get; set; }
        public INotificationRepository Notifications { get; set; }
        public IUserNotificationRepository UserNotifications { get; set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Gigs = new GigRepository(context);
            Genres = new GenreRepository(context);
            Attendances = new AttendanceRepository(context);
            Followings = new FollowingRepository(context);
            Users = new ApplicationUserRepository(context);
            Notifications = new NotificationRepository(context);
            UserNotifications = new UserNotificationRepository(context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}