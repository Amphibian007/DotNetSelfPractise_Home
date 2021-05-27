using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismPractise
{
    public interface INotificationChannel
    {
        void Send(Message message);
    }
}
