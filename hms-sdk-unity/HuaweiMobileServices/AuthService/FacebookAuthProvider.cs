using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class FacebookAuthProvider
    {
        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.auth.FacebookAuthProvider");

        public static AGConnectAuthCredential CredentialWithToken(string paramString)
            => javaClass.CallStaticAsWrapper<AGConnectAuthCredential>("credentialWithToken", paramString);

        public static AGConnectAuthCredential CredentialWithToken(string paramString, bool paramBoolean)
            => javaClass.CallStaticAsWrapper<AGConnectAuthCredential>("credentialWithToken", paramString, paramBoolean);
    }
}
