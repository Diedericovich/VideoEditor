using System;
using System.Collections.Generic;
using System.Text;

namespace VideoEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Email email = new Email();
            Letter letter = new Letter();
            SMS sms = new SMS();
            List<Notification> notifications = new List<Notification>();
            notifications.Add(sms);
            notifications.Add(letter);
            notifications.Add(email);

            Processor processor = new Processor(notifications);
            
            processor.Process();




        }
    }
}
