using System;
using System.Collections.Generic;
using System.Text;

namespace EventsPractise
{
    public class TextService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"Message service. Sending a text message...{e.Video.Title} is encoded");
        }
    }
}
