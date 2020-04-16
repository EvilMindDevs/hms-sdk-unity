namespace HuaweiMobileServices.Ads
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.ads.reward.RewardAd
    public class RewardAd : JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.ads.reward.RewardAd";

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public static RewardAd CreateRewardAdInstance() =>
            sJavaClass.CallStaticAsWrapper<RewardAd>("createRewardAdInstance", AndroidContext.GetActivityContext());

        public RewardAd(AndroidJavaObject javaObject) : base(javaObject) { }

        public RewardAd(string paramString) : base("com.huawei.hms.ads.reward.RewardAd", AndroidContext.GetActivityContext(), paramString) { }

        public virtual Reward Reward => CallAsWrapper<Reward>("getReward");

        public virtual bool Loaded => Call<bool>("isLoaded");

        public virtual void LoadAd(AdParam paramAdParam, IRewardAdLoadListener paramRewardAdLoadListener) =>
            Call("loadAd", paramAdParam, new RewardAdLoadListener(paramRewardAdLoadListener));

        public virtual IOnMetadataChangedListener OnMetadataChangedListener
        {
            set
            {
                Call("setOnMetadataChangedListener", new OnMetadataChangedListener(value));
            }
        }

        public virtual void Show(IRewardAdStatusListener paramRewardAdStatusListener, bool paramBoolean) =>
            Call("show", AndroidContext.GetActivityContext(), new RewardAdStausListener(paramRewardAdStatusListener), paramBoolean);

        public virtual void Show(IRewardAdStatusListener paramRewardAdStatusListener) =>
            Call("show", AndroidContext.GetActivityContext(), new RewardAdStausListener(paramRewardAdStatusListener));

        public virtual RewardVerifyConfig RewardVerifyConfig => CallAsWrapper<RewardVerifyConfig>("getRewardVerifyConfig");

        public virtual void Destroy() => Call("destroy", AndroidContext.GetActivityContext());

        public virtual IRewardAdListener RewardAdListener
        {
            set
            {
                Call("setRewardAdListener", new RewardAdListenerWrapper(value));
            }
        }

        public virtual string Data => CallAsString("getData");

        public virtual string UserId => CallAsString("getUserId");

        public virtual void LoadAd(string paramString, AdParam paramAdParam) => Call("loadAd", paramString, paramAdParam);

        public virtual void Pause() => Call("pause", AndroidContext.GetActivityContext());

        public virtual void Resume() => Call("resume", AndroidContext.GetActivityContext());

        public virtual bool Immersive => Call<bool>("isImmersive");

        public virtual void Show() => Call("show");

    }

}