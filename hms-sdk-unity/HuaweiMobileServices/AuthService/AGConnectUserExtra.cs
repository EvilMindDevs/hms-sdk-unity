using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class AGConnectUserExtra : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public AGConnectUserExtra(AndroidJavaObject javaObject) : base(javaObject) { }
        public AGConnectUserExtra() : base("com.huawei.agconnect.auth.AGConnectUserExtra") { }

        public string CreateTime => Call<string>("getCreateTime"); 

        public string LastSignInTime => Call<string>("getLastSignInTime");    
    }
}
