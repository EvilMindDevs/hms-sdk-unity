using HuaweiMobileServices.CloudDB;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.CloudDB
{
    internal class OnSnapshotListenerWrapper<T> : AndroidJavaProxy where T : ICloudDBZoneObject, new()
    {
        private Action<CloudDBZoneSnapshot<T>> mCloudDBZoneSnapshot;

        private Action<AGConnectCloudDBException> mAGConnectCloudDBException;

        public OnSnapshotListenerWrapper(Action<CloudDBZoneSnapshot<T>> onCloudDBZoneSnapshot, Action<AGConnectCloudDBException> onAGConnectCloudDBException) :
            base("com.huawei.agconnect.cloud.database.OnSnapshotListener")
        {
            mCloudDBZoneSnapshot = onCloudDBZoneSnapshot;
            mAGConnectCloudDBException = onAGConnectCloudDBException;
        }

        public void onSnapshot(AndroidJavaObject snapshot, AndroidJavaObject e)
        {
            this.CallOnMainThread(() => {
                try
                {
                    mCloudDBZoneSnapshot?.Invoke(snapshot.AsWrapper<CloudDBZoneSnapshot<T>>());

                    string msg = "";
                    int code = 0;
                    if (e != null)
                    {
                        msg = e.Call<string>("getMessage");
                        code = e.Call<int>("getCode");
                    }

                    mAGConnectCloudDBException?.Invoke(new AGConnectCloudDBException(msg, code));
                }
                catch (Exception ex)
                {
                    Debug.Log("CloudDB OnSnapshotListenerWrapper error " + ex);
                }
            });
        }

    }
}
