using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.CloudStorage
{
    public class UploadTask : JavaObjectWrapper
    {
        public UploadTask(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.storage.core.UploadTask");

        public void OnPaused() => javaClass.Call("onPaused");


        public class UploadResult : JavaObjectWrapper
        {
            public UploadResult(AndroidJavaObject javaObject) : base(javaObject) { }

            private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.storage.core.UploadTask$UploadResult");

            public long BytesTransferred
            {
                get => Call<long>("getBytesTransferred");
            }

            public long TotalByteCount
            {
                get => Call<long>("getTotalByteCount");
            }

            public FileMetadata MetaData
            {
                get => CallAsWrapper<FileMetadata>("getMetadata");
            }
        }
    }
}
