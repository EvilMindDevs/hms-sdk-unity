namespace HuaweiMobileServices.Scan
{
    using HuaweiMobileServices.Utils;

    using UnityEngine;

    // Wrapper for com.huawei.hms.hmsscankit.OnResultCallback
    internal class OnResultCallback : JavaObjectWrapper
    {
        private class OnResultCallbackInterfaceWrapper : AndroidJavaProxy
        {
            private readonly IOnResultCallback mListener;

            public OnResultCallbackInterfaceWrapper(IOnResultCallback listener) : base("org.m0skit0.android.hms.unity.scan.OnResultCallbackWrapper")
            {
                mListener = listener;
            }

            public void OnResult(HmsScan[] result)
            {
                this.CallOnMainThread(() => { mListener.OnResult(result); });
            }
        }

        public OnResultCallback(IOnResultCallback listener)
            : base("org.m0skit0.android.hms.unity.scan.OnResultCallbackWrapper", new OnResultCallbackInterfaceWrapper(listener)) { }
    }
}
