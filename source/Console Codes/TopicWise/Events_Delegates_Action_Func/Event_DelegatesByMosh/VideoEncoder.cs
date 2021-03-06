﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Event_DelegatesByMosh
{
    public class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video....");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this,new VideoEventArgs(){
                Video=video
            });

        }
    }
}
