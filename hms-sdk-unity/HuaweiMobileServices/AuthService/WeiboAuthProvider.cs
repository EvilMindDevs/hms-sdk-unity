using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class WeiboAuthProvider
    {
        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.auth.WeiboAuthProvider");

        public static AGConnectAuthCredential CredentialWithToken(string paramString, string paramString2)
            => javaClass.CallStaticAsWrapper<AGConnectAuthCredential>("credentialWithToken", paramString, paramString2);

        public static AGConnectAuthCredential CredentialWithToken(string paramString, bool paramBoolean)
            => javaClass.CallStaticAsWrapper<AGConnectAuthCredential>("credentialWithToken", paramString, paramBoolean);

    }
}
