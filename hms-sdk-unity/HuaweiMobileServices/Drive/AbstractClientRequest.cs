using System;
using System.Collections.Generic;
using System.Text;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public abstract class AbstractClientRequest<T> : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public AbstractClientRequest(AndroidJavaObject javaObject) : base(javaObject) { }
        public T Execute()
        {
            return Call<T>("execute");
        }
        public MediaHttpDownloader GetMediaHttpDownloader()
        {
            return CallAsWrapper<MediaHttpDownloader>("getMediaHttpDownloader");
        }
        public MediaHttpUploader GetMediaHttpUploader()
        {
            return CallAsWrapper<MediaHttpUploader>("getMediaHttpUploader");
        }
        
    }
}
