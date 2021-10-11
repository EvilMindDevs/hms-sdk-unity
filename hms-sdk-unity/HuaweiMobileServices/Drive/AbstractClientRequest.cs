using System;
using System.Collections.Generic;
using System.Text;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public abstract class AbstractClientRequest<T> : JavaObjectWrapper
    {
        public AbstractClientRequest(AndroidJavaObject javaObject) : base(javaObject) { }
        public T Execute() => Call<T>("execute");
        public MediaHttpDownloader GetMediaHttpDownloader() => CallAsWrapper<MediaHttpDownloader>("getMediaHttpDownloader");
        public MediaHttpUploader GetMediaHttpUploader() => CallAsWrapper<MediaHttpUploader>("getMediaHttpUploader");
    }
}
