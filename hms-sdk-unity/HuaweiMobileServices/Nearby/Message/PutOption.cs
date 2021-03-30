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
        public PutCallback Callback => Call<PutCallback>("getCallback");
        public Policy Policy => CallAsWrapper<Policy>("getPolicy");

        public class Builder : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.nearby.message.PutOption$Builder") { }
            public GetOption Build() => CallAsWrapper<GetOption>("build");
            public Builder SetPolicy(Policy policy) => CallAsWrapper<Builder>("setPolicy", policy);
            public Builder SetCallback(PutCallback callback) => CallAsWrapper<Builder>("setCallback", callback);

        }

    }
}
