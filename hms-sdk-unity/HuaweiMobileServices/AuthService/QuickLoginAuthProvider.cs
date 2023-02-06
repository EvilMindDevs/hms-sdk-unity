using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class QuickLoginAuthProvider
    {
        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.auth.QuickLoginAuthProvider");

        public static AGConnectAuthCredential CredentialWithToken(string token)
            => javaClass.CallStaticAsWrapper<AGConnectAuthCredential>("credentialWithToken", token, token);

        public static AGConnectAuthCredential CredentialWithToken(string token, bool autoCreateUser)
            => javaClass.CallStaticAsWrapper<AGConnectAuthCredential>("credentialWithToken", token, autoCreateUser);

    }
}
