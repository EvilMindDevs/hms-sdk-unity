using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Ads
{
    public interface IRewardAdStausListener
    {
        void OnRewardAdClosed();
        void OnRewardAdFailedToShow(int errorCode);
        void OnRewardAdOpened();
        void OnRewarded(Reward reward);
    }
}
