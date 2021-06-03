namespace HuaweiMobileServices.Ads
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.ads.reward.RewardAdListener
    internal class RewardAdListenerWrapper : AndroidJavaProxy
    {
        private readonly IRewardAdListener mListener;

        public RewardAdListenerWrapper(IRewardAdListener listener) : base("com.huawei.hms.ads.reward.RewardAdListener")
        {
            mListener = listener;
        }

        public void onRewarded(AndroidJavaObject reward)
        {
            this.CallOnMainThread(() => { mListener.OnRewarded(reward.AsWrapper<Reward>()); });
        }

        public void onRewardAdClosed()
        {
            this.CallOnMainThread(() => { mListener.OnRewardAdClosed(); });
        }

        public void onRewardAdFailedToLoad(int errorCode)
        {
            this.CallOnMainThread(() => { mListener.OnRewardAdFailedToLoad(errorCode); });
        }

        public void onRewardAdLeftApp()
        {
            this.CallOnMainThread(() => { mListener.OnRewardAdLeftApp(); });
        }

        public void onRewardAdLoaded()
        {
            this.CallOnMainThread(() => { mListener.OnRewardAdLoaded(); });
        }

        public void onRewardAdOpened()
        {
            this.CallOnMainThread(() => { mListener.OnRewardAdOpened(); });
        }

        public void onRewardAdCompleted()
        {
            this.CallOnMainThread(() => { mListener.OnRewardAdCompleted(); });
        }

        public void onRewardAdStarted()
        {
            this.CallOnMainThread(() => { mListener.OnRewardAdStarted(); });
        }
    }
}
