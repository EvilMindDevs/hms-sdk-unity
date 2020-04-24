using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Ads
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.ads.HwAds
    public static class HwAds
    {

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ads.HwAds");

        public static void Init() => sJavaClass.CallStatic("init", AndroidContext.ActivityContext);

    }
}
