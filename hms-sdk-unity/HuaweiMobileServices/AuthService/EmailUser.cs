using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class EmailUser : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public EmailUser(AndroidJavaObject javaObject) : base(javaObject) { }
        public EmailUser(string paramString1, string paramString2, string paramString3) :
            base("com.huawei.agconnect.auth.EmailUser", paramString1, paramString2, paramString3) { }

        public string Email
        {
            get { return Call<string>("getEmail"); }
        }

        public int VerifyEmailUser(bool paramBoolean) => Call<int>("verifyEmailUser", paramBoolean);

        public class Builder : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }
            public Builder() : base("com.huawei.agconnect.auth.EmailUser$Builder") { }

            public Builder SetPassword(string param1String) => CallAsWrapper<Builder>("setPassword", param1String);
            public Builder SetEmail(string param1String) => CallAsWrapper<Builder>("setEmail", param1String);
            public Builder SetVerifyCode(string param1String) => CallAsWrapper<Builder>("setVerifyCode", param1String);
            public EmailUser Build() => CallAsWrapper<EmailUser>("build");
        }
    }
}
