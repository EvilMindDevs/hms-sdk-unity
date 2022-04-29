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

        ///<summary>
        ///<para>Resets a user's password using the email address.</para>
        ///</summary>
        public ITask<Void> ResetPassword(string email, string newPassword, string verifyCode) 
            => CallAsWrapper<TaskVoidWrapper>("resetPassword", email, newPassword, verifyCode);

        ///<summary>
        ///<para>Resets a user's password using the mobile number.</para>
        ///</summary>
        public ITask<Void> ResetPassword(string countryCode, string phoneNumber, string newPassword, string verifyCode)
            => CallAsWrapper<TaskVoidWrapper>("resetPassword", countryCode, phoneNumber, newPassword, verifyCode);

        ///<summary>
        ///<para>Applies for a verification code using an email address.</para>
        ///</summary>
        public ITask<VerifyCodeResult> RequestVerifyCode(string email, VerifyCodeSettings settings)
           => CallAsWrapper<TaskJavaObjectWrapper<VerifyCodeResult>>("requestVerifyCode", email, settings);

        ///<summary>
        ///<para>Applies for a verification code using a mobile number.</para>
        ///</summary>
        public ITask<VerifyCodeResult> RequestVerifyCode(string countryCode, string phoneNumber, VerifyCodeSettings settings)
            => CallAsWrapper<TaskJavaObjectWrapper<VerifyCodeResult>>("requestVerifyCode", countryCode, phoneNumber, settings);
    }
}
