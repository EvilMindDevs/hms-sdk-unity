using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class AlipayAuthProvider
    {
        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.auth.AlipayAuthProvider");

        public static AGConnectAuthCredential CredentialWithAuthCode(string authCode)
            => javaClass.CallStaticAsWrapper<AGConnectAuthCredential>("credentialWithAuthCode", authCode);

        public static AGConnectAuthCredential CredentialWithAuthCode(string authCode, bool autoCreateUser)
            => javaClass.CallStaticAsWrapper<AGConnectAuthCredential>("credentialWithAuthCode", authCode, autoCreateUser);
    }
}
