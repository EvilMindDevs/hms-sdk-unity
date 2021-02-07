using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.CloudDB
{
    public class AGConnectCloudDBException : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public AGConnectCloudDBException(AndroidJavaObject javaObject) : base(javaObject) { }
        public AGConnectCloudDBException(string msg, int code) : base("com.huawei.agconnect.cloud.database.exceptions.AGConnectCloudDBException", msg, code) { }

        public int GetCode() => Call<int>("getCode"); 
        public string GetErrMsg() => Call<string>("getErrMsg");
        public string GetMessage() => Call<string>("getMessage");
    }
}
