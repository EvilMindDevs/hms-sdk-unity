using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class PhoneAuthProvider
    {
        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.auth.PhoneAuthProvider");

        public static AGConnectAuthCredential CredentialWithPassword(string paramString1, string paramString2, string paramString3) 
            => javaClass.CallStaticAsWrapper<AGConnectAuthCredential>("credentialWithPassword", paramString1, paramString2, paramString3);

        public static AGConnectAuthCredential CredentialWithVerifyCode(string paramString1, string paramString2, string paramString3, string paramString4)
            => javaClass.CallStaticAsWrapper<AGConnectAuthCredential>("credentialWithVerifyCode", paramString1, paramString2, paramString3, paramString4);

        [Obsolete("Deprecated use AGConnectAuth.requestVerifyCode(String countryCode, String phoneNumber, VerifyCodeSettings settings) instead.")]
        public static ITask<VerifyCodeResult> RequestVerifyCode(string countryCode, string phoneNumber, VerifyCodeSettings paramVerifyCodeSettings) 
            => javaClass.CallStaticAsWrapper<TaskJavaObjectWrapper<VerifyCodeResult>>("requestVerifyCode", countryCode, phoneNumber, paramVerifyCodeSettings);

        [Obsolete("Deprecated use AGConnectAuth.requestVerifyCode(String countryCode, String phoneNumber, VerifyCodeSettings settings) instead.")]
        public static void VerifyPhoneCode(String countryCode, String phoneNumber, VerifyCodeSettings paramVerifyCodeSettings, 
            OnVerifyCodeCallBack paramOnVerifyCodeCallBack) => javaClass.CallStatic("verifyPhoneCode", countryCode, phoneNumber,
                paramVerifyCodeSettings, paramOnVerifyCodeCallBack);
    }

}
