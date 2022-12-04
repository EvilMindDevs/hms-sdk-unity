using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Ads.NativeAd
{
    public class NativeAdConfiguration : JavaObjectWrapper
    {
        //wrapper for com.huawei.hms.ads.nativead.NativeAdConfiguration
        //https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/nativeadconfiguration-0000001050066859

        public NativeAdConfiguration(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ads.nativead.NativeAdConfiguration");

        public static explicit operator NativeAdConfiguration(AndroidJavaObject v) => new NativeAdConfiguration(v);

        public AdSize AdSize
        {
            get => CallAsWrapper<AdSize>("getAdSize");
        }

        public int ChoicesPosition
        {
            get => sJavaClass.Get<int>("getChoicesPosition");
        }

        public int MediaAspect
        {
            get => sJavaClass.Get<int>("getMediaAspect");
        }

        public int MediaDirection
        {
            get => sJavaClass.Get<int>("getMediaDirection");
        }

        public VideoConfiguration VideoConfiguration
        {
            get => CallAsWrapper<VideoConfiguration>("getVideoConfiguration");
        }

        public bool IsRequestMultiImages() => Call<bool>("isRequestMultiImages");

        public bool IsReturnUrlsForImages() => Call<bool>("isReturnUrlsForImages");

        //wrapper for com.huawei.hms.ads.nativead.NativeAdConfiguration.Builder
        //https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/nativeadconfiguration-builder-0000001050064912
        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.ads.nativead.NativeAdConfiguration$Builder", AndroidContext.ActivityContext) { }

            public NativeAdConfiguration Build() => CallAsWrapper<NativeAdConfiguration>("build");

            public Builder SetAdSize(AdSize adSize) => CallAsWrapper<Builder>("setAdSize", adSize);

            public Builder SetChoicesPosition(int choicesPosition) => CallAsWrapper<Builder>("setChoicesPosition", choicesPosition);

            public Builder SetMediaAspect(int aspect) => CallAsWrapper<Builder>("setMediaAspect", aspect);

            public Builder SetMediaDirection(int direction) => CallAsWrapper<Builder>("setMediaDirection", direction);

            public Builder SetRequestCustomDislikeThisAd(bool requestCustomDislikeThisAd) => CallAsWrapper<Builder>("setRequestCustomDislikeThisAd", requestCustomDislikeThisAd);

            public Builder SetRequestMultiImages(bool requestMultiImages) => CallAsWrapper<Builder>("setRequestMultiImages", requestMultiImages);

            public Builder SetReturnUrlsForImages(bool returnUrls) => CallAsWrapper<Builder>("setReturnUrlsForImages", returnUrls);

            public Builder SetVideoConfiguration(VideoConfiguration videoConfiguration) => CallAsWrapper<Builder>("setVideoConfiguration", videoConfiguration);

        }

    }
}