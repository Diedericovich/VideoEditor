using System;
using System.Collections.Generic;
using System.Text;

namespace VideoEditor
{
    class SMS : Notification
    {
        public string PhoneNumber { get; set; }

        public override void Send(string message)
        {
            Console.WriteLine(" *** Sending SMS ***");
            base.Send(message);
        }




    }
}
