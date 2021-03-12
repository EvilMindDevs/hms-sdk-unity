using HuaweiMobileServices.Utils;
using System;
using UnityEngine;


namespace HuaweiMobileServices.Nearby.Message
{
    public class GetCallback : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public GetCallback(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.message.GetCallback");
        public void OnTimeout() => androidJavaClass.Call("onTimeout");
    }
}
