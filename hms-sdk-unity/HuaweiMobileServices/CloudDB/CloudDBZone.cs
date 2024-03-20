using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.CloudDB
{
    public class CloudDBZone : JavaObjectWrapper
    {
        public CloudDBZone(AndroidJavaObject javaObject) : base(javaObject) { }
        public CloudDBZone(CloudDBZoneConfig paramCloudDBZoneConfig) : base("com.huawei.agconnect.cloud.database.CloudDBZone", paramCloudDBZoneConfig) { }

        public CloudDBZoneConfig GetCloudDBZoneConfig() => CallAsWrapper<CloudDBZoneConfig>("getCloudDBZoneConfig");

        public ITask<ServerStatus> ExecuteServerStatusQuery() => CallAsWrapper<TaskJavaObjectWrapper<ServerStatus>>("executeServerStatusQuery");

        public ITask<int> ExecuteUpsert(IList<AndroidJavaObject> objectList) => CallAsWrapper<TaskPrimitive<int>>("executeUpsert", objectList.AsJavaList());

        public ITask<int> ExecuteUpsert(ICloudDBZoneObject cloudDBZoneObject) => CallAsWrapper<TaskPrimitive<int>>("executeUpsert", cloudDBZoneObject);

        public ITask<int> ExecuteDelete(ICloudDBZoneObject cloudDBZoneObject) => CallAsWrapper<TaskPrimitive<int>>("executeDelete", cloudDBZoneObject);

        public ITask<int> ExecuteDelete(IList<AndroidJavaObject> objectList)=> CallAsWrapper<TaskPrimitive<int>>("executeDelete", objectList.AsJavaList());

        public ITask<CloudDBZoneSnapshot<T>> ExecuteQuery<T>(CloudDBZoneQuery cloudDBZoneQuery, 
            CloudDBZoneQuery.CloudDBZoneQueryPolicy queryPolicy) where T:ICloudDBZoneObject, new()
            => CallAsWrapper<TaskJavaObjectWrapper<CloudDBZoneSnapshot<T>>>("executeQuery", cloudDBZoneQuery, queryPolicy);
       
        public ITask<double> ExecuteAverageQuery(CloudDBZoneQuery cloudDBZoneQuery, CloudDBZoneQuery.CloudDBZoneQueryPolicy queryPolicy) 
            => CallAsWrapper<TaskPrimitive<double>>("executeQuery", cloudDBZoneQuery, queryPolicy);
         
        public ITask<int> ExecuteSumQuery(CloudDBZoneQuery cloudDBZoneQuery, string fieldName, CloudDBZoneQuery.CloudDBZoneQueryPolicy queryPolicy) 
            => CallAsWrapper<TaskPrimitive<int>>("executeSumQuery", cloudDBZoneQuery, fieldName, queryPolicy);

        public ITask<int> ExecuteMaximumQuery(CloudDBZoneQuery cloudDBZoneQuery, string fieldName, CloudDBZoneQuery.CloudDBZoneQueryPolicy queryPolicy)
           => CallAsWrapper<TaskPrimitive<int>>("executeMaximumQuery", cloudDBZoneQuery, fieldName, queryPolicy);

        public ITask<int> ExecuteMinimalQuery(CloudDBZoneQuery cloudDBZoneQuery, string fieldName, CloudDBZoneQuery.CloudDBZoneQueryPolicy queryPolicy)
           => CallAsWrapper<TaskPrimitive<int>>("executeMinimalQuery", cloudDBZoneQuery, fieldName, queryPolicy);

        public ITask<long> ExecuteCountQuery(CloudDBZoneQuery cloudDBZoneQuery, string fieldName, CloudDBZoneQuery.CloudDBZoneQueryPolicy queryPolicy)
           => CallAsWrapper<TaskPrimitive<long>>("executeCountQuery", cloudDBZoneQuery, fieldName, queryPolicy);

        public ITask<CloudDBZoneSnapshot<T>> ExecuteQueryUnsynced<T>(CloudDBZoneQuery cloudDBZoneQuery) where T : ICloudDBZoneObject, new()
            => CallAsWrapper<TaskJavaObjectWrapper<CloudDBZoneSnapshot<T>>>("executeQueryUnsynced", cloudDBZoneQuery);

        public ListenerHandler SubscribeSnapshot<T>(CloudDBZoneQuery cloudDBZoneQuery, CloudDBZoneQuery.CloudDBZoneQueryPolicy cloudDBZoneQueryPolicy,
            Action<CloudDBZoneSnapshot<T>> mCloudDBZoneSnapshot, Action<AGConnectCloudDBException> mAGConnectCloudDBException) where T : ICloudDBZoneObject, new()
            => CallAsWrapper<ListenerHandler>("subscribeSnapshot", cloudDBZoneQuery, cloudDBZoneQueryPolicy,
                new OnSnapshotListenerWrapper<T>(mCloudDBZoneSnapshot, mAGConnectCloudDBException));
    }
}
