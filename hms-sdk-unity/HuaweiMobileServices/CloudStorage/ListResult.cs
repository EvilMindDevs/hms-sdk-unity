using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.CloudStorage
{
    public class ListResult : JavaObjectWrapper
    {
        public ListResult(AndroidJavaObject javaObject) : base(javaObject) { }

       // private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.storage.core.ListResult");

        public IList<StorageReference> FileList
        {
            get => CallAsWrapperList<StorageReference>("getFileList");
        }

        public IList<StorageReference> DirList
        {
            get => CallAsWrapperList<StorageReference>("getDirList");
        }

        public string PageMarker
        {
            get => Call<string>("getPageMarker");
        }

        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

           // private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.storage.core.ListResult$Builder");

            public ListResult Build() => CallAsWrapper<ListResult>("build");
        }

    }
}
