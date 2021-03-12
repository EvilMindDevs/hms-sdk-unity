using HuaweiMobileServices.Utils;
using System;
using UnityEngine;


namespace HuaweiMobileServices.Nearby.Message
{
    public class GetOption : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public GetOption(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.message.GetOption");
        public static GetOption DEFAULT => androidJavaClass.GetStaticAsWrapper<GetOption>("DEFAULT");

        public GetCallback GetCallback => androidJavaClass.Call<GetCallback>("getCallback");
        public MessagePicker MessagePicker => androidJavaClass.Call<MessagePicker>("getPicker");
        public Policy Policy => androidJavaClass.Call<Policy>("getPolicy");
        public String ToStringObject => androidJavaClass.Call<String>("toString");
        public class Builder : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.nearby.message.GetOption$Builder") { }
            public GetOption Build() => CallAsWrapper<GetOption>("build");
            public Builder SetCallBack(GetCallback callback) => Call<Builder>("setCallback", callback);
            public Builder SetPicker(MessagePicker picker) => Call<Builder>("setPicker", picker);
            public Builder SetPolicy(Policy policy) => Call<Builder>("setPolicy", policy);


        }
    }
}
