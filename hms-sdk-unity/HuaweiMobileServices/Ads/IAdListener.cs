using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Ads
{
    public interface IAdListener
    {
        void OnAdClosed();
        void OnAdFailed(int reason);
        void OnAdLeave();
        void OnAdOpened();
        void OnAdLoaded();
        void OnAdClicked();
        void OnAdImpression();
    }
}
