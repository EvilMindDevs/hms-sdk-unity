using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class AGConnectAuth : JavaObjectWrapper
    {
        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.auth.AGConnectAuth");

        [UnityEngine.Scripting.Preserve]
        public AGConnectAuth(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AGConnectAuth GetInstance() => javaClass.CallStaticAsWrapper<AGConnectAuth>("getInstance");

        public ITask<SignInResult> SignIn(AGConnectAuthCredential paramAGConnectAuthCredential) 
            => CallAsWrapper<TaskJavaObjectWrapper<SignInResult>>("signIn", paramAGConnectAuthCredential);

        public ITask<SignInResult> SignInAnonymously() => CallAsWrapper<TaskJavaObjectWrapper<SignInResult>>("signInAnonymously");

        public void DeleteUser() => Call("deleteUser");

        public void SignOut() => Call("signOut");

        public AGConnectUser GetCurrentUser() => CallAsWrapper<AGConnectUser>("getCurrentUser");

        public ITask<SignInResult> CreateUser(EmailUser paramEmailUser) => CallAsWrapper<TaskJavaObjectWrapper<SignInResult>>("createUser", paramEmailUser);

        public ITask<SignInResult> CreateUser(PhoneUser paramPhoneUser) => CallAsWrapper<TaskJavaObjectWrapper<SignInResult>>("createUser", paramPhoneUser);

        public ITask<Void> ResetPassword(string paramString1, string paramString2, string paramString3) 
            => CallAsWrapper<TaskVoidWrapper>("resetPassword", paramString1, paramString2, paramString3);

        public ITask<Void> ResetPassword(string paramString1, string paramString2, string paramString3, string paramString4)
            => CallAsWrapper<TaskVoidWrapper>("resetPassword", paramString1, paramString2, paramString3, paramString4);
       
    }
}
