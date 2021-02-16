using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.CloudDB
{
    public partial class CloudDBZoneConfig : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public CloudDBZoneConfig(AndroidJavaObject javaObject) : base(javaObject) { }
        public CloudDBZoneConfig(string cloudDBZoneNameSource, CloudDBZoneSyncProperty cloudDBZoneSyncProperty, CloudDBZoneAccessProperty cloudDBZoneAccessProperty) :
            base("com.huawei.agconnect.cloud.database.CloudDBZoneConfig", cloudDBZoneNameSource, cloudDBZoneSyncProperty, cloudDBZoneAccessProperty) { }

        public string CloudDBZoneName => Call<string>("getCloudDBZoneName"); 

        public CloudDBZoneSyncProperty SyncProperty => CallAsWrapper<CloudDBZoneSyncProperty>("getSyncProperty"); 

        public CloudDBZoneAccessProperty AccessProperty => CallAsWrapper<CloudDBZoneAccessProperty>("getAccessProperty"); 

        public bool IsEncrypted() => Call<bool>("isEncrypted");

        public void SetEncryptedKey(string key, string rekey) => Call("setEncryptedKey", key, rekey);

        public bool PersistenceEnabled
        {
            get => Call<bool>("getPersistenceEnabled"); 
            set => Call("setPersistenceEnabled", value); 
        }

        public long Capacity
        {
            get => Call<long>("getCapacity"); 
            set => Call("setCapacity", value); 
        }

        public class CloudDBZoneAccessProperty : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public CloudDBZoneAccessProperty(AndroidJavaObject javaObject) : base(javaObject) { }
            public CloudDBZoneAccessProperty() : base("com.huawei.agconnect.cloud.database.CloudDBZoneConfig$CloudDBZoneAccessProperty") { }

            private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.database.CloudDBZoneConfig$CloudDBZoneAccessProperty");

            public static CloudDBZoneAccessProperty CLOUDDBZONE_PUBLIC => sJavaClass.GetStaticAsWrapper<CloudDBZoneAccessProperty>("CLOUDDBZONE_PUBLIC");
        }

        public class CloudDBZoneSyncProperty : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public CloudDBZoneSyncProperty(AndroidJavaObject javaObject) : base(javaObject) { }
            public CloudDBZoneSyncProperty() : base("com.huawei.agconnect.cloud.database.CloudDBZoneConfig$CloudDBZoneAccessProperty") { }

            private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.database.CloudDBZoneConfig$CloudDBZoneSyncProperty");

            public static CloudDBZoneSyncProperty CLOUDDBZONE_LOCAL_ONLY => sJavaClass.GetStaticAsWrapper<CloudDBZoneSyncProperty>("CLOUDDBZONE_LOCAL_ONLY");
            public static CloudDBZoneSyncProperty CLOUDDBZONE_CLOUD_CACHE => sJavaClass.GetStaticAsWrapper<CloudDBZoneSyncProperty>("CLOUDDBZONE_CLOUD_CACHE");
        }
    }
}
