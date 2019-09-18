﻿using System;


namespace Shiny.Notifications
{
    public enum SoundType
    {
        Off,
        SystemDefault,
        Custom
    };

    public class Notification
    {
        public static string DefaultTitle { get; set; }
        public static SoundType DefaultSoundType { get; set; } = SoundType.Custom;
        public static string DefaultSound { get; set; }

        public int Id { get; set; }
        public string Title { get; set; } = DefaultTitle;
        public string Message { get; set; }
        public DateTimeOffset? ScheduleDate { get; set; }

        /// <summary>
        /// Configure the type of sound that should be played with the notification
        /// </summary>
        public SoundType SoundType { get; set; } = DefaultSoundType;

        /// <summary>
        /// Play a sound from the native platform (for sound type Custom)
        /// </summary>
        public string Sound { get; set; } = DefaultSound;

        /// <summary>
        /// Additional data you can add to your notification
        /// </summary>
        public string Payload { get; set; }


        /// <summary>
        /// Options specific to android
        /// </summary>
        public AndroidOptions Android { get; set; } = new AndroidOptions();


        /// <summary>
        /// Options specific to windows (Uwp)
        /// </summary>
        public UwpOptions Windows { get; set; } = new UwpOptions();
    }
}