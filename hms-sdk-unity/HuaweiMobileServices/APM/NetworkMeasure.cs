using HuaweiMobileServices.Utils;

using System.Collections.Generic;

using UnityEngine;

namespace HuaweiMobileServices.APM
{
    public class NetworkMeasure : JavaObjectWrapper
    {
        public NetworkMeasure(AndroidJavaObject javaObject) : base(javaObject) { }
        public NetworkMeasure() : base("com.huawei.agconnect.apms.custom.NetworkMeasure") { }

        public static readonly AndroidJavaClass networkMeasure = new AndroidJavaClass("com.huawei.agconnect.apms.custom.NetworkMeasure");
        public void Start() => Call("start");
        public void Stop() => Call("stop");
        public void SetStatusCode(int statusCode) => Call("setStatusCode", statusCode);
        public void SetBytesSent(long btyesSent) => Call("setBytesSent", btyesSent);
        public void SetBytesReceived(long bytesReceived) => Call("setBytesReceived", bytesReceived);
        public void SetContentType(string contentType) => Call("setContentType", contentType);
        public void PutProperty(string propertyName, string propertyValue) => Call("putProperty", propertyName, propertyValue);
        public void RemoveProperty(string propertyName) => Call("removeProperty", propertyName);
        public Dictionary<string, string> GetProperties() => Call<Dictionary<string, string>>("getProperties");
        public string GetProperty(string propertyName) => CallAsString("getProperty", propertyName);
    }
}