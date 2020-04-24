using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Ads
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

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
                mListener.OnRewardAdClosed();
            }

            public void onRewardAdFailedToShow(int errorCode)
            {
                mListener.OnRewardAdFailedToShow(errorCode);
            }

            public void onRewardAdOpened()
            {
                mListener.OnRewardAdOpened();
            }

            public void onRewarded(AndroidJavaObject reward)
            {
                mListener.OnRewarded(new Reward(reward));
            }
        }

        public RewardAdStatusListener(IRewardAdStatusListener listener)
            : base("org.m0skit0.android.hms.unity.ads.RewardAdStatusListenerWrapper", new RewardAdStatusListenerInterfaceWrapper(listener)) { }
    }
}
