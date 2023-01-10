using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.CloudStorage
{
    public class FileMetadata : JavaObjectWrapper
    {
        public FileMetadata(AndroidJavaObject javaObject) : base(javaObject) { }

        public FileMetadata() : base("com.huawei.agconnect.cloud.storage.core.FileMetadata") { }

        // private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.storage.core.FileMetadata");

       /* 
        public class Builder : JavaObjectWrapper 
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

           // private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.storage.core.FileMetadata$Builder");

            public FileMetadata Build() => CallAsWrapper<FileMetadata>("build");
        }*/
        public string Bucket
        {
            get => Call<string>("getBucket");
        }

        public string CTime
        {
            get => Call<string>("getCTime");
        }

        public string MTime
        {
            get => Call<string>("getMTime");
        }

        public string Name
        {
            get => Call<string>("getName");
        }

        public string Path
        {
            get => Call<string>("getPath");
        }

        public long Size
        {
            get => Call<long>("getSize");
        }

        public string SHA256Hash
        {
            get => Call<string>("getSHA256Hash");
            set => Call("setSHA256Hash", value);
        }

        public string ContentType
        {
            get => Call<string>("getContentType");
            set => Call("setContentType", value);
        }

        public string CacheControl
        {
            get => Call<string>("getCacheControl");
            set => Call("setCacheControl", value);
        }

        public string ContentDisposition
        {
            get => Call<string>("getContentDisposition");
            set => Call("setContentDisposition", value);
        }

        public string ContentEncoding
        {
            get => Call<string>("getContentEncoding");
            set => Call("setContentEncoding", value);
        }

        public string ContentLanguage
        {
            get => Call<string>("getContentLanguage");
            set => Call("setContentLanguage", value);
        }

        public IMap<string,string> CustomMetadata
        {
            get => Call<IMap<string, string>>("getCustomMetadata");
            set => Call("setCustomMetadata", value);
        }

        public StorageReference StorageReference
        {
            get => CallAsWrapper<StorageReference>("getStorageReference");
        }

    }
}
