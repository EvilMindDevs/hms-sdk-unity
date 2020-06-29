using System;

namespace HuaweiMobileServices.Utils
{
    using HuaweiMobileServices.Base;
    using UnityEngine;

    internal static class GenericBridgeWrapper
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.GenericBridge");

        public static void CallGenericBridge(this JavaObjectWrapper javaObjectWrapper, String methodName, Action onSuccess, Action<HMSException> onFailure)
        {

            javaObjectWrapper.CallAsWrapper<TaskAndroidJavaObject>(methodName)
                .AddOnSuccessListener((intent) =>
                {
                    var callback = new GenericBridgeCallbackWrapper()
                   .AddOnFailureListener(onFailure)
                   .AddOnSuccessListener((nothing) =>
                   {
                       onSuccess.Invoke();
                   });
                    sJavaClass.CallStatic("receiveShow", intent, callback);

                }).AddOnFailureListener((exception) => onFailure.Invoke(exception));
        }
    }
}
