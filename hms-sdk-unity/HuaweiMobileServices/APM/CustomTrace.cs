using HuaweiMobileServices.Utils;

using System.Collections.Generic;

using UnityEngine;

namespace HuaweiMobileServices.APM
{
    public class CustomTrace : JavaObjectWrapper
    {
        public CustomTrace(AndroidJavaObject javaObject) : base(javaObject) { }
        public CustomTrace() : base("com.huawei.agconnect.apms.custom.CustomTrace") { }

        public static readonly AndroidJavaClass customTrace = new AndroidJavaClass("com.huawei.agconnect.apms.custom.CustomTrace");
        public void Start() => Call("start");
        public void Stop() => Call("stop");
        public void PutProperty(string propertyName, string propertyValue) => Call("putProperty", propertyName, propertyValue);
        public void RemoveProperty(string propertyName) => Call("removeProperty", propertyName);
        public string GetProperty(string propertyName) => CallAsString("getProperty", propertyName);
        public void IncrementMeasure(string measureName, long measureValue) => Call("incrementMeasure", measureName, measureValue);
        public long GetMeasure(string measureName) => Call<long>("getMeasure", measureName);
        public void PutMeasure(string measureName, long measureValue) => Call("putMeasure", measureName, measureValue);
        //public Dictionary<string, string> GetTraceProperties() => Call<Dictionary<string, string>>("getTraceProperties");
        public Dictionary<string, object> GetTraceProperties() => Call<AndroidJavaObject>("getTraceProperties").AsDictionary();
    }
}