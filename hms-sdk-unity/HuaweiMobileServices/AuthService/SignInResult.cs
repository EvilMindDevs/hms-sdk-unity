using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class SignInResult : JavaObjectWrapper
    {
        
        public SignInResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public AGConnectUser GetUser() => CallAsWrapper<AGConnectUser>("getUser");

    }
}
