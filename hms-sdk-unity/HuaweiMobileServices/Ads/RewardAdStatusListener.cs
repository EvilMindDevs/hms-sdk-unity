namespace HuaweiMobileServices.Ads
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class RewardAdStatusListener : JavaObjectWrapper
    {
        private class RewardAdStatusListenerInterfaceWrapper : AndroidJavaProxy
        {

            private readonly IRewardAdStatusListener mListener;

            public RewardAdStatusListenerInterfaceWrapper(IRewardAdStatusListener listener) : base("org.m0skit0.android.hms.unity.ads.RewardAdStatusListener")
            {
                mListener = listener;
            }

            public void onRewardAdClosed()
            {
                this.CallOnMainThread(() => { mListener.OnRewardAdClosed(); });
            }

            public void onRewardAdFailedToShow(int errorCode)
            {
                this.CallOnMainThread(() => { mListener.OnRewardAdFailedToShow(errorCode); });
            }

            public void onRewardAdOpened()
            {
                this.CallOnMainThread(() => { mListener.OnRewardAdOpened(); });
            }

            public void onRewarded(AndroidJavaObject reward)
            {
                this.CallOnMainThread(() => { mListener.OnRewarded(new Reward(reward)); });
            }
        }

        public RewardAdStatusListener(IRewardAdStatusListener listener)
            : base("org.m0skit0.android.hms.unity.ads.RewardAdStatusListenerWrapper", new RewardAdStatusListenerInterfaceWrapper(listener)) { }
    }
}
