namespace HuaweiMobileServices.Base
{
    using System;
    using UnityEngine;

    // Wrapper for com.huawei.hmf.tasks.OnSuccessListener
    // For Java class instances, needs conversion function
    internal class OnSuccessListenerConverterWrapper<T> : AndroidJavaProxy
    {
        protected readonly Action<T> mListener;
        private readonly Func<AndroidJavaObject, T> mConverter;

        public OnSuccessListenerConverterWrapper(Action<T> listener, Func<AndroidJavaObject, T> func) : base("com.huawei.hmf.tasks.OnSuccessListener")
        {
            mListener = listener;
            mConverter = func;
        }

        // WARNING: DO NO MODIFY METHOD NAME onSuccess, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onSuccess(AndroidJavaObject result)
        {
            T convertedResult = mConverter(result);
            mListener.Invoke(convertedResult);
        }
    }

    // Wrapper for com.huawei.hmf.tasks.OnSuccessListener
    // For primitive types, no conversion needed
    internal class OnSuccessListenerWrapper<T> : AndroidJavaProxy
    {
        protected readonly Action<T> mListener;

        public OnSuccessListenerWrapper(Action<T> listener) : base("com.huawei.hmf.tasks.OnSuccessListener")
        {
            mListener = listener;
        }

        // WARNING: DO NO MODIFY METHOD NAME onSuccess, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onSuccess(T result)
        {
            mListener.Invoke(result);
        }
    }
}
