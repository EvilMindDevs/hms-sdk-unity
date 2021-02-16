using HuaweiMobileServices.CloudDB;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.CloudDB
{
    public class OnSnapshotListener : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public OnSnapshotListener() : base("com.huawei.agconnect.cloud.database.OnSnapshotListener") { }
        public OnSnapshotListener(AndroidJavaObject javaObject) : base(javaObject) { }

        public void OnSnapshot(CloudDBZoneSnapshot paramCloudDBZoneSnapshot, AGConnectCloudDBException paramAGConnectCloudDBException) 
            => Call("onSnapshot", paramCloudDBZoneSnapshot, paramAGConnectCloudDBException);
    }

    public class OnSnapshotListener<T> : OnSnapshotListener where T : ICloudDBZoneObject, new()
    {
        public OnSnapshotListener(AndroidJavaObject javaObject) : base(javaObject) { }

        public void OnSnapshot(CloudDBZoneSnapshot<T> paramCloudDBZoneSnapshot, AGConnectCloudDBException paramAGConnectCloudDBException)
            => Call("onSnapshot", paramCloudDBZoneSnapshot, paramAGConnectCloudDBException);
    }
}
