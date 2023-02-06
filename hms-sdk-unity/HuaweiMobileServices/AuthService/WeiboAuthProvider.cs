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

        public static AGConnectAuthCredential CredentialWithToken(string token, string uid)
            => javaClass.CallStaticAsWrapper<AGConnectAuthCredential>("credentialWithToken", token, uid);

        public static AGConnectAuthCredential CredentialWithToken(string token, string uid, bool autoCreateUser)
            => javaClass.CallStaticAsWrapper<AGConnectAuthCredential>("credentialWithToken", token, uid, autoCreateUser);

    }
}
