using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Message
{
    public class PutOption : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public PutOption(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.message.PutOption");

        public static AndroidJavaObject Callback => androidJavaClass.Call<AndroidJavaObject>("getCallback");
        public static AndroidJavaObject Policy => androidJavaClass.Call<AndroidJavaObject>("getPolicy");

        public class Builder : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.nearby.message.PutOption$Builder") { }
            public GetOption Build() => CallAsWrapper<GetOption>("build");
            public Builder SetPolicy(AndroidJavaObject policy) => Call<Builder>("setPolicy", policy);
            public Builder SetCallback(AndroidJavaObject callback) => Call<Builder>("setCallback", callback);

        }

    }
}
