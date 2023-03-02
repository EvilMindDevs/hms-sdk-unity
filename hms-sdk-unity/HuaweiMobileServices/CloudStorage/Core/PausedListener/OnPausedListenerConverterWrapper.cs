namespace HuaweiMobileServices.Base
{
    using System;
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hmf.tasks.OnPausedListener
    // For Java class instances, needs conversion function
    internal class OnPausedListenerConverterWrapper<T> : AndroidJavaProxy
    {
        protected readonly Action<T> mListener;
        private readonly Func<AndroidJavaObject, T> mConverter;

        public OnPausedListenerConverterWrapper(Action<T> listener, Func<AndroidJavaObject, T> func) : base("com.huawei.agconnect.cloud.storage.core.OnPausedListener")
        {
            mListener = listener;
            mConverter = func;
        }

        // WARNING: DO NO MODIFY METHOD NAME onPaused, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onPaused(AndroidJavaObject result)
        {
            T convertedResult = mConverter(result);
            this.CallOnMainThread(() => { mListener.Invoke(convertedResult); });
        }
    }

    // Wrapper for com.huawei.hmf.tasks.OnPausedListener
    // For primitive types, no conversion needed
    internal class OnPausedListenerWrapper<T> : AndroidJavaProxy
    {
        protected readonly Action<T> mListener;

        public OnPausedListenerWrapper(Action<T> listener) : base("com.huawei.agconnect.cloud.storage.core.OnPausedListener")
        {
            mListener = listener;
        }

        // WARNING: DO NO MODIFY METHOD NAME onPaused, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onPaused(T result)
        {
            this.CallOnMainThread(() => { mListener.Invoke(result); });
        }
    }
}
