using System;
using System.Collections.Generic;
using System.Text;

namespace Event_DelegatesByMosh
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Message service: Sending a text message..."+e.Video.Title);
        }
    }
}
                             