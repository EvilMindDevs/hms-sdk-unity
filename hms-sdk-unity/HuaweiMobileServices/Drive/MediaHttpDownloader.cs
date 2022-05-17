using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class MediaHttpDownloader : JavaObjectWrapper
    {
        public MediaHttpDownloader(AndroidJavaObject javaObject) : base(javaObject) {}

        public virtual MediaHttpDownloader SetDirectDownloadEnabled(bool paramBoolean) => CallAsWrapper<MediaHttpDownloader>("setDirectDownloadEnabled", paramBoolean);
        public virtual MediaHttpDownloaderProgressListenerWrapper GetProgressListener => Call<MediaHttpDownloaderProgressListenerWrapper>("getProgressListener");
        public static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.push.HMSPushService");
        public virtual MediaHttpDownloader SetProgressListener(MediaHttpDownloaderProgressListenerWrapper progressListener) => CallAsWrapper<MediaHttpDownloader>("setProgressListener", progressListener);
        public virtual double? Progress => Call<AndroidJavaObject>("getProgress").AsDouble();
        public virtual long? TotalTimeRequired => Call<AndroidJavaObject>("getTotalTimeRequired").AsLong();
        public MediaHttpDownloader SetContentRange(long var1, long var3) => CallAsWrapper<MediaHttpDownloader>("setContentRange", var1, var3);
        public enum DownloadState
        {
            NOT_STARTED,
            MEDIA_IN_PROGRESS,
            MEDIA_COMPLETE
        }

    }

}
