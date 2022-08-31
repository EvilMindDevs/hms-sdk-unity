using HuaweiMobileServices.Utils;
using HuaweiMobileServices.Utils.java.io;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.CloudStorage
{
    public class StreamDownloadTask : JavaObjectWrapper
    {
        public StreamDownloadTask(AndroidJavaObject javaObject) : base(javaObject) { }

        //private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.storage.core.StreamDownloadTask");


        public class StreamHandler : JavaObjectWrapper
        {
            public StreamHandler(AndroidJavaObject javaObject) : base(javaObject) { }

            //private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.storage.core.StreamDownloadTask$StreamHandler");

            public void ReadStream(StreamDownloadResult state, InputStream stream) => Call("readStream", state, stream);

        }

        public class StreamDownloadResult : JavaObjectWrapper
        {
            public StreamDownloadResult(AndroidJavaObject javaObject) : base(javaObject) { }

            //private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.storage.core.StreamDownloadTask$StreamDownloadResult");

            public long BytesTransferred
            {
                get => Call<long>("getBytesTransferred");
            }

            public long TotalByteCount
            {
                get => Call<long>("getTotalByteCount");
            }

            public InputStream Stream
            {
                get => CallAsWrapper<InputStream>("getStream");
            }

        }

    }
}
