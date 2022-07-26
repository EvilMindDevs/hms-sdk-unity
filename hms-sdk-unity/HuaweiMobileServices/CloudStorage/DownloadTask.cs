using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.CloudStorage
{
    public class DownloadTask : JavaObjectWrapper
    {
        public DownloadTask(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.storage.core.DownloadTask");


        public class DownloadResult : JavaObjectWrapper
        {
            public DownloadResult(AndroidJavaObject javaObject) : base(javaObject) { }

            private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.storage.core.DownloadTask$DownloadResult");

            public long BytesTransferred
            {
                get => Call<long>("getBytesTransferred");
            }

            public long TotalByteCount
            {
                get => Call<long>("getTotalByteCount");
            }
        }
    }
}
