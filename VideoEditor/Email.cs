using System;
using System.Collections.Generic;
using System.Text;

namespace VideoEditor
{
    class Email : Notification
    {
        public string Emailadress { get; set; }

        public override void Send(string message)
        {
            Console.WriteLine(" *** Sending Email ***");
            base.Send(message);
        }

    }
}
