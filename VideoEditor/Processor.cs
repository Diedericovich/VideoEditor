using System.Collections.Generic;

namespace VideoEditor
{
    internal class Processor
    {
        private List<Notification> _notifications;

        public Processor(List<Notification> notifications)
        {
            _notifications = notifications;
        }

        public void Process()
        {
            foreach (var notification in _notifications)
            {
                notification.Send("You're room is booked succesfully");
            }
        }
    }
}