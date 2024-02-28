using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class TwitterAuthProvider
    {
        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.auth.TwitterAuthProvider");

        public static AGConnectAuthCredential CredentialWithToken(string paramString, string paramString2)
            => javaClass.CallStaticAsWrapper<AGConnectAuthCredential>("credentialWithToken", paramString, paramString2);

        public static AGConnectAuthCredential CredentialWithToken(string paramString, bool paramBoolean)
            => javaClass.CallStaticAsWrapper<AGConnectAuthCredential>("credentialWithToken", paramString, paramBoolean);

        public static AGConnectAuthCredential CredentialWithAuthCode(TwitterAuthParam twitterAuthParam, bool autoCreateUser)
            => javaClass.CallStaticAsWrapper<AGConnectAuthCredential>("credentialWithAuthCode", twitterAuthParam, autoCreateUser);

    }
}
