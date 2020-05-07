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
                mListener.OnAdClosed();
            }

            public void onAdFailed(int paramInt)
            {
                mListener.OnAdFailed(paramInt);
            }

            public void onAdLeave()
            {
                mListener.OnAdLeave();
            }

            public void onAdOpened()
            {
                mListener.OnAdOpened();
            }

            public void onAdLoaded()
            {
                mListener.OnAdLoaded();
            }

            public void onAdClicked()
            {
                mListener.OnAdClicked();
            }

            public void onAdImpression()
            {
                mListener.OnAdImpression();
            }
        }

        public AdListenerWrapper(IAdListener listener)
            : base("org.m0skit0.android.hms.unity.ads.AdListenerWrapper", new AdListenerInterfaceWrapper(listener)) { }

    }
}
