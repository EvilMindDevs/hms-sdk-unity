using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Message
{
    public class MessagePicker : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public MessagePicker(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.message.MessagePicker");
        public static MessagePicker INCLUDE_ALL_TYPES => androidJavaClass.GetStaticAsWrapper<MessagePicker>("INCLUDE_ALL_TYPES");
        public class Builder : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.nearby.message.MessagePicker$Builder") { }
            public GetOption Build() => CallAsWrapper<GetOption>("build");
            public Builder IncludeAllTypes() => CallAsWrapper<Builder>("includeAllTypes");
        }
    }
}
