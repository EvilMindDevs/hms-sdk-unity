using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.CloudDB
{
    public class CloudDBZoneObject : JavaObjectWrapper, ICloudDBZoneObject
    {
        
        public CloudDBZoneObject(AndroidJavaObject javaObject) : base(javaObject) { }

        
        public CloudDBZoneObject() : base("com.huawei.agconnect.cloud.database.CloudDBZoneObject") { }

        public string ObjectTypeName => Call<string>("getObjectTypeName"); 

        public string PackageName => Call<string>("getPackageName"); 

        public AndroidJavaObject GetObj()
        {
            return base.JavaObject;
        }

        public void SetObj(AndroidJavaObject arg0)
        {
            base.JavaObject = arg0;
        }
    }

    public interface ICloudDBZoneObject
    {
        AndroidJavaObject GetObj();
        void SetObj(AndroidJavaObject arg0);
    }
}
