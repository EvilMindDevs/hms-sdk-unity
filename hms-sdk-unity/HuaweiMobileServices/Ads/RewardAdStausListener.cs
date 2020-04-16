using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Ads
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    public class RewardAdStausListener : JavaObjectWrapper
    {
        internal class RewardAdStausListenerInterfaceWrapper : AndroidJavaProxy
        {

            private readonly IRewardAdStatusListener mListener;

            public RewardAdStausListenerInterfaceWrapper(IRewardAdStatusListener listener) : base("org.m0skit0.android.hms.unity.ads.RewardAdStausListener")
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

        public RewardAdStausListener(IRewardAdStatusListener listener)
            : base("org.m0skit0.android.hms.unity.ads.RewardAdStausListenerWrapper", new RewardAdStausListenerInterfaceWrapper(listener)) { }
    }
}
