using AutoMapper;
using GigHub.Core;
using GigHub.Core.Dtos;
using GigHub.Core.Models;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebGrease.Css.Extensions;

namespace GigHub.Controllers.Api
{
    [Authorize]
    public class NotificationsController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public NotificationsController()
        {
            
        }

        public NotificationsController(IUnitOfWork unitOfWork)
         {
             _unitOfWork = unitOfWork;
         }

        public IEnumerable<NotificationDto> GetNewNotifications()
        {
            var userId = User.Identity.GetUserId();
            var notifications = _unitOfWork.Notifications.GetNewNotificationFor(userId);

            return notifications.Select(Mapper.Map<Notification, NotificationDto>);

            //manual mapping
            /* return notifications.Select(n => new NotificationDto()
                {
                    DateTime = DateTime.Now,
                    Gig = new GigDto
                    {
                        Artist = new UserDto
                        {
                            Id = n.Gig.Artist.Id,
                            Name = n.Gig.Artist.Name
                        },
                        DateTime = n.Gig.DateTime,
                        Id = n.Gig.Id,
                        IsCanceled = n.Gig.IsCanceled,
                        Venue = n.Gig.Venue
                    },
                    OriginalDateTime = n.OriginalDateTime,
                    OriginalVenue = n.OriginalVenue,
                    Type = n.Type
            });*/

        }

        [HttpPost]
        public IHttpActionResult MarkAsRead()
        {
            var userId = User.Identity.GetUserId();
            var notifications = _unitOfWork.UserNotifications.GetUserNotificationFor(userId);

            notifications.ForEach(n => n.Read());

            _unitOfWork.Complete();

            return Ok();
        }
    }
}
