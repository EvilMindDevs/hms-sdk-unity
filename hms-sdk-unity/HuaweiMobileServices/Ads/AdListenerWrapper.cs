namespace HuaweiMobileServices.Ads
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class AdListenerWrapper : JavaObjectWrapper
    {

        private class AdListenerInterfaceWrapper : AndroidJavaProxy
        {

            private readonly IAdListener mListener;

            public AdListenerInterfaceWrapper(IAdListener listener) : base("org.m0skit0.android.hms.unity.ads.AdListener")
            {
                mListener = listener;
            }

            public void onAdClosed()
            {
                this.CallOnMainThread(() => { mListener.OnAdClosed(); });
            }

            public void onAdFailed(int paramInt)
            {
                this.CallOnMainThread(() => { mListener.OnAdFailed(paramInt); });
            }

            public void onAdLeave()
            {
                this.CallOnMainThread(() => { mListener.OnAdLeave(); });
            }

            public void onAdOpened()
            {
                this.CallOnMainThread(() => { mListener.OnAdOpened(); });
            }

            public void onAdLoaded()
            {
                this.CallOnMainThread(() => { mListener.OnAdLoaded(); });
            }

            public void onAdClicked()
            {
                this.CallOnMainThread(() => { mListener.OnAdClicked(); });
            }

            public void onAdImpression()
            {
                this.CallOnMainThread(() => { mListener.OnAdImpression(); });
            }
        }

        public AdListenerWrapper(IAdListener listener)
            : base("org.m0skit0.android.hms.unity.ads.AdListenerWrapper", new AdListenerInterfaceWrapper(listener)) { }

    }
}
