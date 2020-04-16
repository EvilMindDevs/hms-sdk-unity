namespace HuaweiMobileServices.Ads
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.ads.reward.RewardAdLoadListener
    public class RewardAdLoadListener : JavaObjectWrapper
    {

        internal class RewardAdLoadListenerInterfaceWrapper : AndroidJavaProxy
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