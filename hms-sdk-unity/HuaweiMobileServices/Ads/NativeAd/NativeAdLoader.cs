using HuaweiMobileServices.Ads;
using HuaweiMobileServices.Ads.NativeAd;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace HuaweiMobileServices.Ads.NativeAd
{
    public class NativeAdLoader : JavaObjectWrapper
    {
        //wrapper for com.huawei.hms.ads.nativead.NativeAdLoader
        //https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/nativeadloader-0000001050064916

        public NativeAdLoader(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ads.nativead.NativeAdLoader");

        public static explicit operator NativeAdLoader(AndroidJavaObject v) => new NativeAdLoader(v);

        public void LoadAd(AdParam adParam) => Call("loadAd", adParam);
        public void LoadAds(AdParam adParam, int maxAdsNum) => Call("loadAd", adParam, maxAdsNum);

        public bool IsLoading() => Call<bool>("isLoading");

        //wrapper for com.huawei.hms.ads.nativead.NativeAdLoader.Builder
        //https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/nativeadloader-builder-0000001050066865
        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder(string adUnitID) : base("com.huawei.hms.ads.nativead.NativeAdLoader$Builder", AndroidContext.ActivityContext, adUnitID) { }

            public NativeAdLoader Build() => CallAsWrapper<NativeAdLoader>("build");

            public Builder SetAdListener(IAdListener adListener) => CallAsWrapper<Builder>("setAdListener", new AdListenerWrapper(adListener));

            public Builder SetNativeAdLoadedListener(NativeAdLoadedListener nativeAdLoadedListener) => CallAsWrapper<Builder>("setNativeAdLoadedListener", nativeAdLoadedListener);

            public Builder SetNativeAdOptions(NativeAdConfiguration nativeAdConfiguration) => CallAsWrapper<Builder>("setNativeAdOptions", nativeAdConfiguration);

            //public Builder SetAdsReturnedFromThread(bool var) => CallAsWrapper<Builder>("setAdsReturnedFromThread", var);

        }

    }
}
