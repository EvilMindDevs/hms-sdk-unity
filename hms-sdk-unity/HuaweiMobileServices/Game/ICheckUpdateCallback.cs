using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Game
{
    public interface ICheckUpdateCallback
    {
        void OnUpdateInfo(AndroidIntent intent);
        void OnMarketInstallInfo(AndroidIntent intent);
        void OnMarketStoreError(int responseCode);
        void OnUpdateStoreError(int responseCode);
    }
}