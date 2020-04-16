using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Ads
{
    public interface IRewardAdLoadListener
    {
        void OnRewardAdFailedToLoad(int errorCode);
        void OnRewardedLoaded();
    }
}
