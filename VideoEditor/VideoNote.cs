using System;
using System.Collections.Generic;
using System.Text;

namespace VideoEditor
{
    class VideoNote : Notification
    {
        public override void Send(string message)
        {
            Console.WriteLine(" *** Sending VideoNote ***");
        }


    }
}
