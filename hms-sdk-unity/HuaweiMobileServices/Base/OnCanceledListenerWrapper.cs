namespace HuaweiMobileServices.Base
{
    using HuaweiMobileServices.Utils;
    using System;
    using UnityEngine;

    // Wrapper for com.huawei.hmf.tasks.OnCanceledListener
    internal class OnCanceledListenerWrapper : AndroidJavaProxy
    {

        private readonly Action mListener;

        internal OnCanceledListenerWrapper(Action listener) : base("com.huawei.hmf.tasks.OnCanceledListener")
        {
            mListener = listener;
        }

        public void onCanceled()
        {
            this.CallOnMainThread(() => { mListener.Invoke();});
        }
    }

}
