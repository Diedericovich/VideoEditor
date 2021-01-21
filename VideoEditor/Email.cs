using System;

namespace VideoEditor
{
    internal class Email : Notification
    {
        public string Emailadress { get; set; }

        public override void Send(string message)
        {
            Console.WriteLine(" *** Sending Email ***");
        }
    }
}