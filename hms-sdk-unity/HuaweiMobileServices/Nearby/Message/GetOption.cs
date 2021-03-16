using HuaweiMobileServices.Utils;
using System;
using UnityEngine;


namespace HuaweiMobileServices.Nearby.Message
{
    public class GetOption : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public GetOption(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.message.GetOption");
        public static GetOption DEFAULT => androidJavaClass.GetStaticAsWrapper<GetOption>("DEFAULT");

        public GetCallback GetCallback => CallAsWrapper<GetCallback>("getCallback");
        public MessagePicker MessagePicker => CallAsWrapper<MessagePicker>("getPicker");
        public Policy Policy => CallAsWrapper<Policy>("getPolicy");
        public class Builder : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.nearby.message.GetOption$Builder") { }
            public GetOption Build() => CallAsWrapper<GetOption>("build");
            public Builder SetCallBack(GetCallback callback) => CallAsWrapper<Builder>("setCallback", callback);
            public Builder SetPicker(MessagePicker picker) => CallAsWrapper<Builder>("setPicker", picker);
            public Builder SetPolicy(Policy policy) => CallAsWrapper<Builder>("setPolicy", policy);
        }
    }
}
