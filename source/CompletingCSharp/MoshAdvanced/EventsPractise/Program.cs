using System;

namespace EventsPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            var video1 = new Video { Title = "Dear Zindagi" };
            var videoEncoder = new VideoEncoder();//Publisher
            var mailService = new MailService();//Subscriber
            var textService = new TextService();//Subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += textService.OnVideoEncoded;
            videoEncoder.Encode(video1);
        }
    }
}
