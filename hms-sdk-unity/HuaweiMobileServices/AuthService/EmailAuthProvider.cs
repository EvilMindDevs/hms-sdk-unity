using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class EmailAuthProvider
    {
        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.auth.EmailAuthProvider");

        public static AGConnectAuthCredential CredentialWithPassword(string paramString1, string paramString2)
            => javaClass.CallStaticAsWrapper<AGConnectAuthCredential>("credentialWithPassword", paramString1, paramString2);

        public static AGConnectAuthCredential CredentialWithVerifyCode(string paramString1, string paramString2, string paramString3)
            => javaClass.CallStaticAsWrapper<AGConnectAuthCredential>("credentialWithVerifyCode", paramString1, paramString2, paramString3);

        [Obsolete("Deprecated use AGConnectAuth.requestVerifyCode(String email, VerifyCodeSettings settings) instead.")]
        public static ITask<VerifyCodeResult> RequestVerifyCode(string email, VerifyCodeSettings paramVerifyCodeSettings)
            => javaClass.CallStaticAsWrapper<TaskJavaObjectWrapper<VerifyCodeResult>>("requestVerifyCode", email, paramVerifyCodeSettings);

        [Obsolete("Deprecated use AGConnectAuth.requestVerifyCode(String email, VerifyCodeSettings settings) instead.")]
        public static void VerifyEmailCode(String email, VerifyCodeSettings paramVerifyCodeSettings, OnVerifyCodeCallBack paramOnVerifyCodeCallBack) 
            => javaClass.CallStatic("verifyEmailCode", email, paramVerifyCodeSettings, paramOnVerifyCodeCallBack);
    }
}
