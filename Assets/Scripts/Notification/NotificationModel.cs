using System;

namespace Notification
{
    public class NotificationModel
    {
        public event Action Notification;

        public bool IsNotification = true;

        public void OnNotificationTrue()
        {
            IsNotification = true;
            Notification?.Invoke();
        }

        public void OnNotificationFalse()
        {
            IsNotification = false;
            Notification?.Invoke();
        }
    }
}