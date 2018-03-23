﻿using System;

namespace GigHub.Core.Models
{
    public class UserNotification
    {
        //[Key]
        //[Column(Order = 1)]
        public string UserId { get; private set; }

        //[Key]
        //[Column(Order = 2)]
        public int NotificationId { get; private set; }

        public ApplicationUser User { get; private set; }

        public Notification Notification { get; private set; }

        public bool IsRead { get; private set; }

        protected UserNotification()
        {
        }

        public UserNotification(ApplicationUser user, Notification notification)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            if (notification == null)
                throw new ArgumentNullException("user");

            User = user;
            Notification = notification;

            // I changed the above code with this below code
            //User = user ?? throw new ArgumentNullException(nameof(user));

            //Notification = notification ?? throw new ArgumentNullException(nameof(notification));
        }

        public void Read()
        {
            IsRead = true;
        }
    }
}