namespace HuaweiMobileServices.Ads
{

    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.ads.InterstitialAd
    public class InterstitialAd : JavaObjectWrapper
    {

        public InterstitialAd() : base("com.huawei.hms.ads.InterstitialAd", AndroidContext.ActivityContext) { }

        public IAdListener AdListener
        {
            set => Call("setAdListener", new AdListenerWrapper(value));
        }

        public string AdId
        {
            set => Call("setAdId", value);
        }

        public bool Loaded => Call<bool>("isLoaded");

        public bool Loading => Call<bool>("isLoading");

        public void LoadAd(AdParam paramAdParam)
        {
            Call("loadAd", paramAdParam);
        }

        public void Show()
        {
            Call("show");
        }

        public IRewardAdListener RewardAdListener
        {
            set => Call("setRewardAdListener", new RewardAdListenerWrapper(value));
        }

    }

}