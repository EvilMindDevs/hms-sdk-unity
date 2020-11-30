using System;
using System.Collections.Generic;
using System.Text;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public abstract class AbstractClientRequest<T> : JavaObjectWrapper
    {

        // public AbstractClientRequest(Drive var1, string var2, string var3, File var4, AndroidJavaObject var5) : base("com.huawei.cloud.base.services.AbstractClientRequest", var1, var2, var3, var4, var5) { }
        [UnityEngine.Scripting.Preserve]
        public AbstractClientRequest(AndroidJavaObject javaObject) : base("com.huawei.cloud.base.services.AbstractClientRequest", javaObject) { }
        public T Execute() //throws IOException
        {
            return Call<T>("execute");
        }
        public MediaHttpDownloader GetMediaHttpDownloader()
        {
            return CallAsWrapper<MediaHttpDownloader>("getMediaHttpDownloader");
        }

    }
}
