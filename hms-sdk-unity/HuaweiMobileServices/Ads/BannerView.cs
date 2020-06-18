namespace HuaweiMobileServices.Ads
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.ads.banner.BannerView
    public class BannerView : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public BannerView(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual void Destroy() => Call("destroy");

        public virtual IAdListener AdListener
        {
            set => Call("setAdListener", new AdListenerWrapper(value));
        }

        public virtual BannerAdSize BannerAdSize
        {
            get => CallAsWrapper<BannerAdSize>("getBannerAdSize");
            set => Call("setBannerAdSize", value);
        }

        public virtual string AdId => CallAsString("getAdId");

        public virtual bool Loading => Call<bool>("isLoading");

        public virtual void LoadAd(AdParam paramAdParam) => Call("loadAd", paramAdParam);

        public virtual void Pause() => Call("pause");

        public virtual void Resume() => Call("resume");

        public virtual long BannerRefresh
        {
            set
            {
                Call("setBannerRefresh", value);
            }
        }

    }

}