namespace HuaweiMobileServices.Base
{
    using System;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class OnSuccessListenerWrapper<T> : AndroidJavaProxy
    {
        protected readonly IOnSuccessListener<T> mListener;
        private readonly Func<AndroidJavaObject, T> mConverter;

        public OnSuccessListenerWrapper(IOnSuccessListener<T> listener, Func<AndroidJavaObject, T> func) : base("com.huawei.hmf.tasks.OnSuccessListener")
        {
            mListener = listener;
            mConverter = func;
        }

        public void onSuccess(AndroidJavaObject result)
        {
            T convertedResult = mConverter(result);
            mListener.OnSuccess(convertedResult);
        }
    }
}
