using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismPractise
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail...");
        }
    }
}
