using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class About : JavaObjectWrapper
    {
        public About(AndroidJavaObject javaObject) : base(javaObject) { }
        public About() : base("com.huawei.cloud.services.drive.model.About") { }

        public bool IsNeedUpdate() => CallAsBool("isNeedUpdate");
        public About SetNeedUpdate(bool var1) => CallAsWrapper<About>("setNeedUpdate", var1);
        public string GetUpdateUrl() => Call<string>("getUpdateUrl");
        public About SetUpdateUrl(string var1) => CallAsWrapper<About>("setUpdateUrl", var1);
        public string GetCategory() => Call<string>("getCategory");
        public About SetCategory(string var1) => CallAsWrapper<About>("setCategory", var1);
        public long? GetMaxFileUploadSize() => Call<AndroidJavaObject>("getMaxFileUploadSize").AsLong();
        public About SetMaxFileUploadSize(long var1) => CallAsWrapper<About>("setMaxFileUploadSize", var1);
        public StorageQuota GetStorageQuota() => CallAsWrapper<StorageQuota>("getStorageQuota");
        public About SetStorageQuota(StorageQuota var1) => CallAsWrapper<About>("setStorageQuota", var1);
        public User GetUser() => CallAsWrapper<User>("getUser");
        public About SetUser(User var1) => CallAsWrapper<About>("setUser", var1);
        public long? GetMaxThumbnailSize() => Call<AndroidJavaObject>("getMaxThumbnailSize").AsLong();
        public About SetMaxThumbnailSize(long var1) => CallAsWrapper<About>("setMaxThumbnailSize", var1);
        public About Set(string var1, AndroidJavaObject var2) => CallAsWrapper<About>("set", var1, var2);
        public About Clone() => CallAsWrapper<About>("clone");

        public class StorageQuota : JavaObjectWrapper
        {
            public StorageQuota(AndroidJavaObject javaObject) : base(javaObject) { }            
            public StorageQuota() : base("com.huawei.cloud.services.drive.model.About$StorageQuota") { }

            public long? GetUserCapacity() => Call<AndroidJavaObject>("getUserCapacity").AsLong();
            public StorageQuota SetUserCapacity(long var1) => CallAsWrapper<StorageQuota>("setUserCapacity", var1);
            public long? GetUsedSpace() => Call<AndroidJavaObject>("getUsedSpace").AsLong();
            public StorageQuota SetUsedSpace(long var1) => CallAsWrapper<StorageQuota>("setUsedSpace", var1);
            public StorageQuota Set(string var1, AndroidJavaObject var2) => CallAsWrapper<StorageQuota>("set", var1, var2);
            public StorageQuota Clone() => CallAsWrapper<StorageQuota>("clone");
        }
    }
}
