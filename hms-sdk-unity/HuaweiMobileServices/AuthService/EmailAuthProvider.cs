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

        public static ITask<VerifyCodeResult> RequestVerifyCode(string paramString1, VerifyCodeSettings paramVerifyCodeSettings)
            => javaClass.CallStaticAsWrapper<TaskJavaObjectWrapper<VerifyCodeResult>>("requestVerifyCode", paramString1, paramVerifyCodeSettings);

        public static void VerifyEmailCode(String paramString1, VerifyCodeSettings paramVerifyCodeSettings, OnVerifyCodeCallBack paramOnVerifyCodeCallBack) 
            => javaClass.CallStatic("verifyPhoneCode", paramString1, paramVerifyCodeSettings, paramOnVerifyCodeCallBack);
    }
}
