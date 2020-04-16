using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Ads
{
    public interface IRewardAdStatusListener
    {
        void OnRewardAdClosed();
        void OnRewardAdFailedToShow(int errorCode);
        void OnRewardAdOpened();
        void OnRewarded(Reward reward);
    }
}
