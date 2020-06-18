using System;
using System.Threading.Tasks;

namespace HuaweiMobileServices.Id
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class HuaweiIdAuthService : JavaObjectWrapper
    {

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.GenericBridge");

        [UnityEngine.Scripting.Preserve]
        public HuaweiIdAuthService(AndroidJavaObject javaObject) : base(javaObject) { }

        public void StartSignIn(Action<AuthHuaweiId> onSuccess, Action<HMSException> onFailure)
        {
            var intent = Call<AndroidJavaObject>("getSignInIntent");
            var callback = new GenericBridgeCallbackWrapper()
                .AddOnFailureListener(onFailure)
                .AddOnSuccessListener((resultIntent) =>
                {
                    HuaweiIdAuthManager.ParseAuthResultFromIntent(resultIntent)
                        .AddOnFailureListener(onFailure)
                        .AddOnSuccessListener((authHuaweiId) =>
                        {
                            onSuccess.Invoke(authHuaweiId);
                        });
                });
            sJavaClass.CallStatic("receiveShow", intent, callback);
        }

        public Task<AuthHuaweiId> StartSignInAsync()
        {
            var task = new TaskCompletionSource<AuthHuaweiId>();
            StartSignIn(task.SetResult, task.SetException);
            return task.Task;
        }

        public ITask<Void> CancelAuthorization() => CallAsWrapper<TaskVoidWrapper>("cancelAuthorization");

        public ITask<Void> SignOut() => CallAsWrapper<TaskVoidWrapper>("signOut");

        public ITask<AuthHuaweiId> SilentSignIn() => CallAsWrapper<TaskJavaObjectWrapper<AuthHuaweiId>>("silentSignIn");
    }
}
