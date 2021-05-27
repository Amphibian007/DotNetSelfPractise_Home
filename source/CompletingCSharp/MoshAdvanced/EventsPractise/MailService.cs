using System;
using System.Collections.Generic;
using System.Text;

namespace EventsPractise
{
    public class MailService
    {
        public void OnVideoEncoded(object source,VideoEventArgs e)
        {
            Console.WriteLine("Mail service. Sending an email..."+e.Video.Title +" is encoded" );
        }
    }
  
}
