using HuaweiMobileServices.Common;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.CloudStorage
{
    public class AGCStorageManagement : JavaObjectWrapper
    {
        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.storage.core.AGCStorageManagement");

        public AGCStorageManagement(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AGCStorageManagement GetInstance()
        {
            return sJavaClass.CallStaticAsWrapper<AGCStorageManagement>("getInstance");
        }
        /* TODO if needed add HttpURLConnectionFactory interface. There is no document on AGC check java sdk.
        public static AGCStorageManagement GetInstance(HttpURLConnectionFactory factory)
        {
            return sJavaClass.CallStaticAsWrapper<AGCStorageManagement>("getInstance", factory);
        }
        
        public static AGCStorageManagement GetInstance(string bucketName, HttpURLConnectionFactory factory)
        {
            return sJavaClass.CallStaticAsWrapper<AGCStorageManagement>("getInstance", bucketName, factory);
        }
        
        public static AGCStorageManagement GetInstance(AGConnectInstance instance, string bucketName, HttpURLConnectionFactory factory)
        {
            return sJavaClass.CallStaticAsWrapper<AGCStorageManagement>("getInstance", instance, bucketName, factory);
        } 
         */

        public static AGCStorageManagement GetInstance(string bucketName)
        {
            return sJavaClass.CallStaticAsWrapper<AGCStorageManagement>("getInstance", bucketName);
        }

        public static AGCStorageManagement GetInstance(AGConnectInstance instance, string bucketName)
        {
            return sJavaClass.CallStaticAsWrapper<AGCStorageManagement>("getInstance", instance, bucketName);
        }

        public StorageReference GetStorageReference() => CallAsWrapper<StorageReference>("getStorageReference");

        public StorageReference GetStorageReference(string objectPath) => CallAsWrapper<StorageReference>("getStorageReference", objectPath);

        public StorageReference GetReferenceFromUrl(AGConnectInstance instance, string fullUrl) => CallAsWrapper<StorageReference>("getReferenceFromUrl", instance, fullUrl);

        public long MaxUploadTimeout
        {
            get => Call<long>("getMaxUploadTimeout");
            set => Call("setMaxUploadTimeout", value);
        }

        public long MaxDownloadTimeout
        {
            get => Call<long>("getMaxDownloadTimeout");
            set => Call("setMaxDownloadTimeout", value);
        }

        public long MaxRequestTimeout
        {
            get => Call<long>("getMaxRequestTimeout");
            set => Call("setMaxRequestTimeout", value);
        }

        public int RetryTimes
        {
            get => Call<int>("getRetryTimes");
            set => Call("setRetryTimes", value);
        }

        public string Area
        {
            get => Call<string>("getArea");
        }
    }
}
