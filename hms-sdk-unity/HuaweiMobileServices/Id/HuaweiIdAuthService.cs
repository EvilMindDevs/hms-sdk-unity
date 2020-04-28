using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Id
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;
    using HuaweiMobileServices.Base;

    public class HuaweiIdAuthService : JavaObjectWrapper
    {

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.auth.AuthBridge");

        public HuaweiIdAuthService(AndroidJavaObject javaObject) : base(javaObject) { }

        public void StartSignIn(Action<AuthHuaweiId> onSuccess, Action<Exception> onFailure)
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
            sJavaClass.CallStatic("receiveStartSignIn", intent, callback);
        }

        public ITask<Void> CancelAuthorization() => CallAsWrapper<TaskVoidWrapper>("cancelAuthorization");

        public ITask<Void> SignOut() => CallAsWrapper<TaskVoidWrapper>("signOut");

        public ITask<AuthHuaweiId> SilentSignIn() => CallAsWrapper<TaskJavaObjectWrapper<AuthHuaweiId>>("silentSignIn");
    }
}
