namespace HuaweiMobileServices.Ads
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.ads.reward.RewardAdLoadListener
    internal class RewardAdLoadListener : JavaObjectWrapper
    {

        private class RewardAdLoadListenerInterfaceWrapper : AndroidJavaProxy
        {

            private readonly IRewardAdLoadListener mListener;

            public RewardAdLoadListenerInterfaceWrapper(IRewardAdLoadListener listener) : base("org.m0skit0.android.hms.unity.ads.RewardAdLoadListener")
            {
                mListener = listener;
            }

            public void onRewardedLoaded()
            {
                mListener.OnRewardedLoaded();
            }

            public void onRewardAdFailedToLoad(int errorCode)
            {
                mListener.OnRewardAdFailedToLoad(errorCode);
            }

        }

        public RewardAdLoadListener(IRewardAdLoadListener listener)
            : base("org.m0skit0.android.hms.unity.ads.RewardAdLoadListenerWrapper", new RewardAdLoadListenerInterfaceWrapper(listener)) { }

    }

}