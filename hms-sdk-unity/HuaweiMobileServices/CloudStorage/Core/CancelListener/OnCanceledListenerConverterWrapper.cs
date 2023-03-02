namespace HuaweiMobileServices.Base
{

    using System;
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hmf.tasks.OnCanceledListener
    // For Java class instances, needs conversion function
    internal class OnCanceledListenerConverterWrapper<T> : AndroidJavaProxy
    {
        protected readonly Action<T> mListener;
        private readonly Func<AndroidJavaObject, T> mConverter;

        public OnCanceledListenerConverterWrapper(Action<T> listener, Func<AndroidJavaObject, T> func) : base("com.huawei.hmf.tasks.OnCanceledListener")
        {
            mListener = listener;
            mConverter = func;
        }
        // WARNING: DO NO MODIFY METHOD NAME onCanceled, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onCanceled(AndroidJavaObject result)
        {
            T convertedResult = mConverter(result);
            this.CallOnMainThread(() => { mListener.Invoke(convertedResult); });
        }
    }

    // Wrapper for com.huawei.hmf.tasks.OnCanceledListener
    // For primitive types, no conversion needed
    internal class OnCanceledListenerWrapper<T> : AndroidJavaProxy
    {
        protected readonly Action mListener;

        public OnCanceledListenerWrapper(Action listener) : base("com.huawei.hmf.tasks.OnCanceledListener")
        {
            mListener = listener;
        }

        // WARNING: DO NO MODIFY METHOD NAME onCanceled, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onCanceled()
        {
            this.CallOnMainThread(() => { mListener.Invoke(); });
        }
    }

}
