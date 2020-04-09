namespace HuaweiMobileServices.Base
{
    using System;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hmf.tasks.OnSuccessListener
    internal class OnSuccessListenerWrapper<T> : AndroidJavaProxy
    {
        protected readonly Action<T> mListener;
        private readonly Func<AndroidJavaObject, T> mConverter;

        public OnSuccessListenerWrapper(Action<T> listener, Func<AndroidJavaObject, T> func) : base("com.huawei.hmf.tasks.OnSuccessListener")
        {
            mListener = listener;
            mConverter = func;
        }

        public void onSuccess(AndroidJavaObject result)
        {
            T convertedResult = mConverter(result);
            mListener.Invoke(convertedResult);
        }
    }
}
