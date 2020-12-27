using System;
using System.Threading;

namespace Event_DelegatesByMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            var video1 = new Video { Title = "Dipto video" };
            var videoEncoder1 = new VideoEncoder();//publiser
            var mailService1 = new MailService();//subscriber
            var messageService1 = new MessageService();//subscriber

            videoEncoder1.VideoEncoded += mailService1.OnVideoEncoded;
            videoEncoder1.VideoEncoded += messageService1.OnVideoEncoded;
            videoEncoder1.Encode(video1);
           
        }
    }

   

}
