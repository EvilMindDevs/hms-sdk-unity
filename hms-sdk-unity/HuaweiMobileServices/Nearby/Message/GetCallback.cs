using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Message
{
    public class GetCallback : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public GetCallback(AndroidJavaObject javaObject) : base(javaObject) { }
        public void OnTimeout() => Call("onTimeout");
    }
}
