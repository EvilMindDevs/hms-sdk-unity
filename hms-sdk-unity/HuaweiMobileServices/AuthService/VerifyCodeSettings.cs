using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class VerifyCodeSettings : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public VerifyCodeSettings(AndroidJavaObject javaObject) : base(javaObject) { }
        public VerifyCodeSettings(int paramInt1, string paramString1, int paramInt2) :
            base("com.huawei.agconnect.auth.VerifyCodeSettings", paramInt1, paramString1, paramInt2) { }

        public static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.agconnect.auth.VerifyCodeSettings");

        public static int ACTION_REGISTER_LOGIN => sJavaClass.GetStatic<int>("ACTION_REGISTER_LOGIN");

        public static int ACTION_RESET_PASSWORD => sJavaClass.GetStatic<int>("ACTION_RESET_PASSWORD");

        public int Action => Call<int>("getAction"); 

        public string Lang => Call<string>("getLang"); 

        public int SendInterval => Call<int>("getSendInterval"); 

        public class Builder : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }
            public Builder() : base("com.huawei.agconnect.auth.VerifyCodeSettings$Builder") { }

            public Builder Locale(Locale arg0) => CallAsWrapper<Builder>("locale", arg0);
            public Builder SendInterval(int arg0) => CallAsWrapper<Builder>("sendInterval", arg0);
            public VerifyCodeSettings Build() => CallAsWrapper<VerifyCodeSettings>("build");
            public Builder Action(int arg0) => CallAsWrapper<Builder>("action", arg0);
        }
    }
}
