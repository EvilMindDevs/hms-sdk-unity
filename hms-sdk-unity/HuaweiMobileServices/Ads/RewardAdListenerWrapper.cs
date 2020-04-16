using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Ads
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

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
            mListener.OnRewarded(reward.AsWrapper<Reward>());
        }

        public void onRewardAdClosed()
        {
            mListener.OnRewardAdClosed();
        }

        public void onRewardAdFailedToLoad(int errorCode)
        {
            mListener.OnRewardAdFailedToLoad(errorCode);
        }

        public void onRewardAdLeftApp()
        {
            mListener.OnRewardAdLeftApp();
        }

        public void onRewardAdLoaded()
        {
            mListener.OnRewardAdLoaded();
        }

        public void onRewardAdOpened()
        {
            mListener.OnRewardAdOpened();
        }

        public void onRewardAdCompleted()
        {
            mListener.OnRewardAdCompleted();
        }

        public void onRewardAdStarted()
        {
            mListener.OnRewardAdStarted();
        }
    }
}
