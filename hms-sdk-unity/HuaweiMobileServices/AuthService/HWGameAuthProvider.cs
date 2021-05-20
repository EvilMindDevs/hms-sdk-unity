using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class HWGameAuthProvider : JavaObjectWrapper
    {
        
        public HWGameAuthProvider(AndroidJavaObject javaObject) : base(javaObject) { }
        public HWGameAuthProvider() : base("com.huawei.agconnect.auth.HWGameAuthProvider") { }

        public class Builder : JavaObjectWrapper
        {
            
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }
            public Builder() : base("com.huawei.agconnect.auth.HWGameAuthProvider$Builder") { }

            public Builder SetPlayerSign(string param1String) => CallAsWrapper<Builder>("setPlayerSign", param1String);
            public Builder SetPlayerId(string param1String) => CallAsWrapper<Builder>("setPlayerId", param1String);
            public Builder SetDisplayName(string param1String) => CallAsWrapper<Builder>("setDisplayName", param1String);
            public Builder SetImageUrl(string param1String) => CallAsWrapper<Builder>("setImageUrl", param1String);
            public Builder SetPlayerLevel(int param1String) => CallAsWrapper<Builder>("setPlayerLevel", param1String);
            public Builder SetSignTs(string param1String) => CallAsWrapper<Builder>("setSignTs", param1String);
            public Builder SetAutoCreateUser(bool param1String) => CallAsWrapper<Builder>("setAutoCreateUser", param1String);
            public AGConnectAuthCredential Build() => CallAsWrapper<AGConnectAuthCredential>("build");
        }

    }
}
