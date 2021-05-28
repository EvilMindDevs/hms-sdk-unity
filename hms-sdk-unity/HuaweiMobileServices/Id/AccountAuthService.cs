using System;
using System.Threading.Tasks;

namespace HuaweiMobileServices.Id
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class AccountAuthService : JavaObjectWrapper
    {

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.GenericBridge");


        public AccountAuthService(AndroidJavaObject javaObject) : base(javaObject) { }

        public void StartSignIn(Action<AuthAccount> onSuccess, Action<HMSException> onFailure)
        {
            var intent = Call<AndroidJavaObject>("getSignInIntent");
            var callback = new GenericBridgeCallbackWrapper()
                .AddOnFailureListener(onFailure)
                .AddOnSuccessListener((resultIntent) =>
                {
                    AccountAuthManager.ParseAuthResultFromIntent(resultIntent)
                          .AddOnFailureListener(onFailure)
                          .AddOnSuccessListener((authHuaweiId) =>
                          {
                              CallOnMainThread(() => { onSuccess.Invoke(authHuaweiId); });
                          });
                });
            sJavaClass.CallStatic("receiveShow", intent, callback);
        }

        public Task<AuthAccount> StartSignInAsync()
        {
            var task = new TaskCompletionSource<AuthAccount>();
            StartSignIn(task.SetResult, task.SetException);
            return task.Task;
        }

        public ITask<Void> CancelAuthorization() => CallAsWrapper<TaskVoidWrapper>("cancelAuthorization");

        public ITask<Void> SignOut() => CallAsWrapper<TaskVoidWrapper>("signOut");

        public ITask<AuthAccount> SilentSignIn() => CallAsWrapper<TaskJavaObjectWrapper<AuthAccount>>("silentSignIn");

        public ITask<AccountIcon> Channel() => CallAsWrapper<TaskJavaObjectWrapper<AccountIcon>>("getChannel");

    }
}
