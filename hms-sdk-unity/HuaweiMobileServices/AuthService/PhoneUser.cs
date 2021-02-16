using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class PhoneUser : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public PhoneUser(AndroidJavaObject javaObject) : base(javaObject) { }
        public PhoneUser(string paramString1, string paramString2, string paramString3, string paramString4) :
            base("com.huawei.agconnect.auth.PhoneUser", paramString1, paramString2, paramString3, paramString4) { }

        public string Phone => Call<string>("getPhone"); 

        public int VerifyPhoneUser(bool paramBoolean) => Call<int>("verifyPhoneUser", paramBoolean);

        public class Builder : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }
            public Builder() : base("com.huawei.agconnect.auth.PhoneUser$Builder") { }

            public Builder SetCountryCode(string param1String) => CallAsWrapper<Builder>("setCountryCode", param1String);
            public Builder SetPhoneNumber(string param1String) => CallAsWrapper<Builder>("setPhoneNumber", param1String);
            public Builder SetPassword(string param1String) => CallAsWrapper<Builder>("setPassword", param1String);
            public Builder SetVerifyCode(string param1String) => CallAsWrapper<Builder>("setVerifyCode", param1String);
            public PhoneUser Build() => CallAsWrapper<PhoneUser>("build");
        }
    }
}
