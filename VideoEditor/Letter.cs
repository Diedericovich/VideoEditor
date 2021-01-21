using System;
using System.Collections.Generic;
using System.Text;

namespace VideoEditor
{
    class Letter : Notification
    {
        public string Adress { get; set; }

        public override void Send(string message)
        {
            Console.WriteLine(" *** Sending Letter ***");
            base.Send(message);
        }

    }
}
