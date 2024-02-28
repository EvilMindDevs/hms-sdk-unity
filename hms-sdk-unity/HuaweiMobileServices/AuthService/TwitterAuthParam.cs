using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class TwitterAuthParam : JavaObjectWrapper
    {
        public TwitterAuthParam(AndroidJavaObject javaObject) : base(javaObject) { }
        public TwitterAuthParam(string clientId, string authCode, string codeVerifier, string redirectUrl) : base("com.huawei.agconnect.auth.TwitterAuthParam", clientId, authCode, codeVerifier, redirectUrl) { }
    }
}