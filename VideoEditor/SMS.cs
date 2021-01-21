using System;

namespace VideoEditor
{
    internal class SMS : Notification
    {
        public string PhoneNumber { get; set; }

        public override void Send(string message)
        {
            Console.WriteLine(" *** Sending SMS ***");
        }
    }
}