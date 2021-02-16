using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.CloudDB
{
    public class CloudDBZoneSnapshot: JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public CloudDBZoneSnapshot() : base("com.huawei.agconnect.cloud.database.CloudDBZoneSnapshot") { }
        public CloudDBZoneSnapshot(AndroidJavaObject javaObject) : base(javaObject) { }

        public bool HasPendingWrites() => Call<bool>("hasPendingWrites");
        public bool IsFromCloud() => Call<bool>("isFromCloud");
        public CloudDBZoneObjectList GetSnapshotObjects() => CallAsWrapper<CloudDBZoneObjectList>("getSnapshotObjects");
        public CloudDBZoneObjectList GetUpsertedObjects() => CallAsWrapper<CloudDBZoneObjectList>("getUpsertedObjects");
        public CloudDBZoneObjectList GetDeletedObjects() => CallAsWrapper<CloudDBZoneObjectList>("getDeletedObjects");

        public void Release() => Call("release");
    }

    
    public class CloudDBZoneSnapshot<T> : CloudDBZoneSnapshot where T : ICloudDBZoneObject, new()
    {
        public CloudDBZoneSnapshot(AndroidJavaObject javaObject) : base(javaObject) { }

        public CloudDBZoneObjectList<T> GetSnapshotObjects() => CallAsWrapper<CloudDBZoneObjectList<T>>("getSnapshotObjects");
        public CloudDBZoneObjectList<T> GetUpsertedObjects() => CallAsWrapper<CloudDBZoneObjectList<T>>("getUpsertedObjects");
        public CloudDBZoneObjectList<T> GetDeletedObjects() => CallAsWrapper<CloudDBZoneObjectList<T>>("getDeletedObjects");
    }
}
