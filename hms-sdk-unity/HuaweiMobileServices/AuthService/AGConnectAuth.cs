using HuaweiMobileServices.Base;
using HuaweiMobileServices.Common;
using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class AGConnectAuth : JavaObjectWrapper
    {
        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.auth.AGConnectAuth");

        
        public AGConnectAuth(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AGConnectAuth GetInstance() => javaClass.CallStaticAsWrapper<AGConnectAuth>("getInstance");

        public static AGConnectAuth GetInstance(AGConnectInstance instance) => javaClass.CallStaticAsWrapper<AGConnectAuth>("getInstance", instance);

        public ITask<SignInResult> SignIn(AGConnectAuthCredential paramAGConnectAuthCredential) 
            => CallAsWrapper<TaskJavaObjectWrapper<SignInResult>>("signIn", paramAGConnectAuthCredential);

        public ITask<SignInResult> SignIn(int provider)
            => CallAsWrapper<TaskJavaObjectWrapper<SignInResult>>("signIn", AndroidContext.ActivityContext, provider);

        public IList<int> GetSupportedAuthList() => CallAsIntList("getSupportedAuthList");

        public ITask<SignInResult> SignInAnonymously() => CallAsWrapper<TaskJavaObjectWrapper<SignInResult>>("signInAnonymously");

        public ITask<Void> DeleteUser() => CallAsWrapper<TaskVoidWrapper>("deleteUser");

        public void SignOut() => Call("signOut");

        public AGConnectUser GetCurrentUser() => CallAsWrapper<AGConnectUser>("getCurrentUser");

        public ITask<SignInResult> CreateUser(EmailUser paramEmailUser) => CallAsWrapper<TaskJavaObjectWrapper<SignInResult>>("createUser", paramEmailUser);

        public ITask<SignInResult> CreateUser(PhoneUser paramPhoneUser) => CallAsWrapper<TaskJavaObjectWrapper<SignInResult>>("createUser", paramPhoneUser);

        public ITask<Void> ResetPassword(string paramString1, string paramString2, string paramString3) 
            => CallAsWrapper<TaskVoidWrapper>("resetPassword", paramString1, paramString2, paramString3);

        public ITask<Void> ResetPassword(string paramString1, string paramString2, string paramString3, string paramString4)
            => CallAsWrapper<TaskVoidWrapper>("resetPassword", paramString1, paramString2, paramString3, paramString4);

        public ITask<VerifyCodeResult> RequestVerifyCode(string email, VerifyCodeSettings settings)
            => (ITask<VerifyCodeResult>)CallAsWrapper<VerifyCodeResult> ("requestVerifyCode", email, settings);

        public ITask<VerifyCodeResult> RequestVerifyCode(string countryCode, string phoneNumber, VerifyCodeSettings settings)
            => (ITask<VerifyCodeResult>)CallAsWrapper<VerifyCodeResult>("requestVerifyCode", countryCode, phoneNumber, settings);
    }
}
