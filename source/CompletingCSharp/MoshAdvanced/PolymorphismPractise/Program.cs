﻿using System;

namespace PolymorphismPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SMSNotificationChannel());
            encoder.Encode(new Video());
         
        }
    }
}
