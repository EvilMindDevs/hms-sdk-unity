using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.CloudStorage
{
    public class UploadTask : StorageTask<UploadTask.UploadResult>
    {
        public UploadTask(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.storage.core.UploadTask");

        public void OnPaused() => javaClass.Call("onPaused");


        public class UploadResult : TimePointStateBase
        {
            //private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.storage.core.UploadTask$UploadResult");

            public UploadResult(AndroidJavaObject javaObject) : base(javaObject) { }

            public static explicit operator UploadResult(AndroidJavaObject v) => new UploadResult(v);

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
