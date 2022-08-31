using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.CloudStorage
{
    public class DownloadTask : StorageTask<DownloadTask.DownloadResult>
    {
        public DownloadTask(AndroidJavaObject javaObject) : base(javaObject) { }

        //private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.storage.core.DownloadTask");


        public class DownloadResult : TimePointStateBase
        {
            //private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.storage.core.DownloadTask$DownloadResult");

            public DownloadResult(AndroidJavaObject javaObject) : base(javaObject) { }

            public static explicit operator DownloadResult(AndroidJavaObject v) => new DownloadResult(v);

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
