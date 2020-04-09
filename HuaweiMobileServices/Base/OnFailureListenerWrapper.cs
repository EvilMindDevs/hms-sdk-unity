namespace HuaweiMobileServices.Base
{
    using System;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hmf.tasks.OnFailureListener
    internal class OnFailureListenerWrapper : AndroidJavaProxy
    {

        private readonly Action<Exception> mListener;

        internal OnFailureListenerWrapper(Action<Exception> listener) : base("com.huawei.hmf.tasks.OnFailureListener")
        {
            mListener = listener;
        }

        public void onFailure(AndroidJavaObject javaException)
        {
            mListener.Invoke(javaException.AsException());
        }
    }
}
