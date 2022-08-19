namespace HuaweiMobileServices.Scan
{
    using HuaweiMobileServices.Utils;

    using UnityEngine;

    // Wrapper for com.huawei.hms.hmsscankit.OnLightVisibleCallBack
    internal class OnLightVisibleCallBackWrapper : JavaObjectWrapper
    {
        private class OnLightVisibleCallBackInterfaceWrapper : AndroidJavaProxy
        {

            private readonly IOnLightVisibleCallBack mListener;

            public OnLightVisibleCallBackInterfaceWrapper(IOnLightVisibleCallBack listener) : base("org.m0skit0.android.hms.unity.scan.OnLightVisibleCallBackWrapper")
            {
                mListener = listener;
            }

            public void OnVisibleChanged(bool visible)
            {
                this.CallOnMainThread(() => { mListener.OnVisibleChanged(visible); });
            }
        }

        public OnLightVisibleCallBackWrapper(IOnLightVisibleCallBack listener)
            : base("org.m0skit0.android.hms.unity.scan.OnLightVisibleCallBackWrapper", new OnLightVisibleCallBackInterfaceWrapper(listener)) { }
    }
}
