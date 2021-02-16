﻿using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.CloudDB
{
    public class AGConnectCloudDB : JavaObjectWrapper
    {
        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.database.AGConnectCloudDB");

        [UnityEngine.Scripting.Preserve]
        public AGConnectCloudDB(AndroidJavaObject javaObject) : base(javaObject) { }

        public static void Initialize() => sJavaClass.CallStatic("initialize", AndroidContext.ActivityContext); 

        public static AGConnectCloudDB GetInstance() => sJavaClass.CallStaticAsWrapper<AGConnectCloudDB>("getInstance");
       
        public void CreateObjectType(ObjectTypeInfo objectTypeInfo) => Call("createObjectType", objectTypeInfo);

        public IList<CloudDBZoneConfig> GetCloudDBZoneConfigs() => Call<AndroidJavaObject>("getCloudDBZoneConfigs").AsListFromWrappable<CloudDBZoneConfig>();

        public CloudDBZone OpenCloudDBZone(CloudDBZoneConfig config, bool isAllowToCreate) => 
            CallAsWrapper<CloudDBZone>("openCloudDBZone", config, isAllowToCreate);

        public ITask<CloudDBZone> OpenCloudDBZone2(CloudDBZoneConfig config, bool isAllowToCreate) => 
            CallAsWrapper<TaskJavaObjectWrapper<CloudDBZone>>("openCloudDBZone2", config, isAllowToCreate);

        public void CloseCloudDBZone(CloudDBZone zone) => Call("closeCloudDBZone", zone);

        public void DeleteCloudDBZone(string zoneName) => Call("deleteCloudDBZone", zoneName);

        public void EnableNetwork(string zoneName) => Call("enableNetwork", zoneName);

        public void DisableNetwork(string zoneName) => Call("disableNetwork", zoneName);

        public ITask<bool> SetUserKey(string userKey, string userReKey) => CallAsWrapper<TaskPrimitive<bool>>("setUserKey", userKey, userReKey);

        public ITask<bool> UpdateDataEncryptionKey() => CallAsWrapper<TaskPrimitive<bool>>("updateDataEncryptionKey");

    }
}
