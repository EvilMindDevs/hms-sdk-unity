namespace HuaweiMobileServices.Ads
{
    using UnityEngine;

    internal class AdListenerWrapper : AndroidJavaProxy
    {

        private readonly IAdListener mListener;

        public AdListenerWrapper(IAdListener listener) : base("com.huawei.hms.ads.AdListener")
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
}
