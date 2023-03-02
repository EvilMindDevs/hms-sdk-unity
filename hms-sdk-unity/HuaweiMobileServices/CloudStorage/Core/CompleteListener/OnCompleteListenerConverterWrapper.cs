namespace HuaweiMobileServices.Base
{
    using System;
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hmf.tasks.OnCompleteListener
    // For Java class instances, needs conversion function
    internal class OnCompleteListenerConverterWrapper<T> : AndroidJavaProxy
    {
        protected readonly Action<T> mListener;
        private readonly Func<AndroidJavaObject, T> mConverter;

        public OnCompleteListenerConverterWrapper(Action<T> listener, Func<AndroidJavaObject, T> func) : base("com.huawei.hmf.tasks.OnCompleteListener")
        {
            mListener = listener;
            mConverter = func;
        }

        // WARNING: DO NO MODIFY METHOD NAME onComplete, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onComplete(AndroidJavaObject result)
        {
            T convertedResult = mConverter(result);
            this.CallOnMainThread(() => { mListener.Invoke(convertedResult); });
        }
    }

    // Wrapper for com.huawei.hmf.tasks.OnCompleteListener
    // For primitive types, no conversion needed
    internal class OnCompleteListenerWrapper<T> : AndroidJavaProxy
    {
        protected readonly Action<T> mListener;

        public OnCompleteListenerWrapper(Action<T> listener) : base("com.huawei.hmf.tasks.OnCompleteListener")
        {
            mListener = listener;
        }

        // WARNING: DO NO MODIFY METHOD NAME onComplete, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onComplete(T result)
        {
            this.CallOnMainThread(() => { mListener.Invoke(result); });
        }
    }
}
