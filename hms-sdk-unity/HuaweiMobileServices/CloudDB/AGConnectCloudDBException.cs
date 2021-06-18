using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.CloudDB
{
    public class AGConnectCloudDBException : JavaObjectWrapper
    {
        
        public AGConnectCloudDBException(AndroidJavaObject javaObject) : base(javaObject) { }
        public AGConnectCloudDBException(string msg, int code) : base("com.huawei.agconnect.cloud.database.exceptions.AGConnectCloudDBException", msg, code) { }

        public int Code => Call<int>("getCode");
        public string ErrMsg => Call<string>("getErrMsg");
        public string Message => Call<string>("getMessage");
    }
}
