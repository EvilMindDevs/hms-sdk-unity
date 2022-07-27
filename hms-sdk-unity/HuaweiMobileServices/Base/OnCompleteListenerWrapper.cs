/*namespace HuaweiMobileServices.Base
{
    using System;
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hmf.tasks.OnCompleteListener
    // For Java class instances, needs conversion function
    internal class OnCompleteListenerConverterWrapper<T> : AndroidJavaProxy
    {
        protected readonly Action<T> mListener;
        private readonly Func<ITask<AndroidJavaObject>, ITask<T>> mConverter;

        public OnCompleteListenerConverterWrapper(Action<T> listener, Func<AndroidJavaObject, ITask<T>> func) : base("com.huawei.hmf.tasks.OnCompleteListener")
        {
            mListener = listener;
            mConverter = func;
        }

        // WARNING: DO NO MODIFY METHOD NAME onComplete, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onComplete(ITask<AndroidJavaObject> result)
        {
            ITask < T > convertedResult = mConverter(result);
            this.CallOnMainThread(() => { mListener.Invoke(convertedResult); });
        }
    }

    // Wrapper for com.huawei.hmf.tasks.OnCompleteListener
    // For primitive types, no conversion needed
    internal class OnCompleteListenerWrapper<T> : AndroidJavaProxy
    {
        protected readonly Action<ITask<T>> mListener;

        public OnCompleteListenerWrapper(Action<ITask<T>> listener) : base("com.huawei.hmf.tasks.OnCompleteListener")
        {
            mListener = listener;
        }

        // WARNING: DO NO MODIFY METHOD NAME onComplete, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onComplete(AndroidJavaObject result)
        {
            this.CallOnMainThread(() => { mListener.Invoke(result.AsWrapper<T>); });
        }
    }
}*/
