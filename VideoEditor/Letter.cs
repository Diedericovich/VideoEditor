using System;

namespace VideoEditor
{
    internal class Letter : Notification
    {
        public string Adress { get; set; }

        public override void Send(string message)
        {
            Console.WriteLine(" *** Sending Letter ***");
        }
    }
}