using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.Ads.NativeAd
{
    public class NativeAdLoadedListener : AndroidJavaProxy
    {

        private readonly INativeAdLoadedListener InativeAdLoadedListener;

        public NativeAdLoadedListener(INativeAdLoadedListener nativeAdLoadedListener) : base("com.huawei.hms.ads.nativead.NativeAd$NativeAdLoadedListener")
        {
            InativeAdLoadedListener = nativeAdLoadedListener;
        }
        public void onNativeAdLoaded(AndroidJavaObject nativeAd)
        {
            InativeAdLoadedListener.onNativeAdLoaded((NativeAd) nativeAd);
        }
    }

    public interface INativeAdLoadedListener
    {
        void onNativeAdLoaded(NativeAd nativeAd);
    }

}
