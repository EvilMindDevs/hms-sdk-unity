using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class MediaHttpUploader : JavaObjectWrapper
    {
        //public MediaHttpUploader(AndroidJavaObject abstractInputStreamContentvar, AndroidJavaObject httpTransportvar, AndroidJavaObject httpRequestInitializervar) : base("com.huawei.cloud.base.media.MediaHttpUploader", abstractInputStreamContentvar, httpTransportvar, httpRequestInitializervar) { }
        public MediaHttpUploader(AndroidJavaObject javaObject) : base(javaObject) { }

        public MediaHttpUploader SetDirectUploadEnabled(bool directUploadEnabled) =>
        CallAsWrapper<MediaHttpUploader>("setDirectUploadEnabled", directUploadEnabled);

        public virtual MediaHttpUploader SetProgressListener(MediaHttpUploaderProgressListenerWrapper progressListener) => CallAsWrapper<MediaHttpUploader>("setProgressListener", progressListener);
        public double Progress
        {
            get => Call<double>("getProgress");
        }
        public long TotalTimeRequired
        {
            get => Call<long>("getTotalTimeRequired");
        }

        public UploadState getUploadState
        {
            get => Call<UploadState>("getUploadState");
        }

        public enum UploadState
        {
            NOT_STARTED,
            INITIATION_STARTED,
            INITIATION_COMPLETE,
            MEDIA_IN_PROGRESS,
            MEDIA_COMPLETE
        }

    }
}
