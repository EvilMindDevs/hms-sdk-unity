using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    class BaseUser : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public BaseUser(AndroidJavaObject javaObject) : base(javaObject) { }
        public BaseUser() : base("com.huawei.agconnect.auth.BaseUser") { }

        public string Password => Call<string>("getPassword"); 

        public string VerifyCode => Call<string>("getVerifyCode"); 
    }
}
