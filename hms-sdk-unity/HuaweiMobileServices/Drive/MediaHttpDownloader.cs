using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class MediaHttpDownloader : JavaObjectWrapper
    {
        public MediaHttpDownloader(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual MediaHttpDownloader SetDirectDownloadEnabled(bool paramBoolean) =>
        CallAsWrapper<MediaHttpDownloader>("setDirectDownloadEnabled", paramBoolean);
        public virtual MediaHttpDownloaderProgressListenerWrapper GetProgressListener
        {
            get => Call<MediaHttpDownloaderProgressListenerWrapper>("getProgressListener");
        }

        public static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.push.HMSPushService");

        public virtual MediaHttpDownloader SetProgressListener(MediaHttpDownloaderProgressListenerWrapper progressListener) => CallAsWrapper<MediaHttpDownloader>("setProgressListener", progressListener);

        public virtual double Progress
        {
            get => Call<double>("getProgress");
        }
        public virtual long TotalTimeRequired
        {
            get => Call<long>("getTotalTimeRequired");
        }
        public virtual DownloadState getDownloadState

        {
            get => Call<DownloadState>("getDownloadState");
        }
        public MediaHttpDownloader SetContentRange(long var1, long var3)
        {
            return CallAsWrapper<MediaHttpDownloader>("setContentRange", var1, var3);
        }
        public enum DownloadState
        {
            NOT_STARTED,
            MEDIA_IN_PROGRESS,
            MEDIA_COMPLETE
        }

    }

}
