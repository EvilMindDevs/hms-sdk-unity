namespace HuaweiMobileServices.Base
{
    using HuaweiMobileServices.Utils;
    using System;
    using UnityEngine;

    // Wrapper for com.huawei.hmf.tasks.OnFailureListener
    internal class OnFailureListenerWrapper : AndroidJavaProxy
    {

        private readonly Action<HMSException> mListener;

        internal OnFailureListenerWrapper(Action<HMSException> listener) : base("com.huawei.hmf.tasks.OnFailureListener")
        {
            mListener = listener;
        }

        public void onFailure(AndroidJavaObject javaException)
        {
            this.CallOnMainThread(() => { mListener.Invoke(javaException.AsException()); });
        }
    }
}
