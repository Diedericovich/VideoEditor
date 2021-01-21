using System.Collections.Generic;

namespace VideoEditor
{
    internal class Program
    {
        private static void Main(string[] args)
        {         
            List<Notification> notifications = new List<Notification>();
            notifications.Add(new SMS());
            notifications.Add(new SMS());
            notifications.Add(new SMS());
            notifications.Add(new SMS());
            notifications.Add(new Letter());
            notifications.Add(new Email());
            notifications.Add(new VideoNote());

            Processor processor = new Processor(notifications);

            processor.Process();
        }
    }
}