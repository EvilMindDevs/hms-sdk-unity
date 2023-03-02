namespace HuaweiMobileServices.Base
{
    using System;
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hmf.tasks.OnProgressListener
    // For Java class instances, needs conversion function
    internal class OnProgressListenerConverterWrapper<T> : AndroidJavaProxy
    {
        protected readonly Action<T> mListener;
        private readonly Func<AndroidJavaObject, T> mConverter;

        public OnProgressListenerConverterWrapper(Action<T> listener, Func<AndroidJavaObject, T> func) : base("com.huawei.agconnect.cloud.storage.core.OnProgressListener")
        {
            mListener = listener;
            mConverter = func;
        }

        // WARNING: DO NO MODIFY METHOD NAME onProgress, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onProgress(AndroidJavaObject result)
        {
            T convertedResult = mConverter(result);
            this.CallOnMainThread(() => { mListener.Invoke(convertedResult); });
        }
    }

    // Wrapper for com.huawei.hmf.tasks.OnProgressListener
    // For primitive types, no conversion needed
    internal class OnProgressListenerWrapper<T> : AndroidJavaProxy
    {
        protected readonly Action<T> mListener;

        public OnProgressListenerWrapper(Action<T> listener) : base("com.huawei.agconnect.cloud.storage.core.OnProgressListener")
        {
            mListener = listener;
        }

        // WARNING: DO NO MODIFY METHOD NAME onProgress, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onProgress(T result)
        {
            this.CallOnMainThread(() => { mListener.Invoke(result); });
        }
    }
}
