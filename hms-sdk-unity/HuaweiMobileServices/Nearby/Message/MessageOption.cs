using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Message
{
    public class MessageOption : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public MessageOption(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.message.MessageOption");
 
        public static int Permissions => androidJavaClass.Call<int>("getPermissions");
 
        public class Builder : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.nearby.message.MessageOption$Builder") { }
            public GetOption Build() => CallAsWrapper<GetOption>("build"); 
            public Builder SetPermissions(int permissions) => CallAsWrapper<Builder>("setPermissions", permissions);
        }
    }
}
