using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class VKAuthProvider
    {
        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.auth.VKAuthProvider");

        public static AGConnectAuthCredential CredentialWithToken(string accessToken, string uid)
            => javaClass.CallStaticAsWrapper<AGConnectAuthCredential>("credentialWithToken", accessToken, uid);

        public static AGConnectAuthCredential CredentialWithToken(string accessToken, string uid, bool autoCreateUser)
            => javaClass.CallStaticAsWrapper<AGConnectAuthCredential>("credentialWithToken", accessToken, uid, autoCreateUser);
    }
}
