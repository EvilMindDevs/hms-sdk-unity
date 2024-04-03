namespace HuaweiMobileServices.Ads
{
    using HuaweiMobileServices.Utils;
    using System;
    using System.Threading.Tasks;
    using UnityEngine;

    // Wrapper for com.huawei.hms.ads.reward.RewardAd
    public class RewardAd : JavaObjectWrapper
    {

        private class LoadAdListener : IRewardAdLoadListener
        {

            private readonly Action mOnSuccess;
            private readonly Action<int> mOnError;

            public LoadAdListener(Action onSuccess, Action<int> onError)
            {
                mOnSuccess = onSuccess;
                mOnError = onError;
            }

            public void OnRewardAdFailedToLoad(int errorCode)
            {
                mOnError.Invoke(errorCode);
            }

            public void OnRewardedLoaded()
            {
                mOnSuccess.Invoke();
            }
        }

        private const string CLASS_NAME = "com.huawei.hms.ads.reward.RewardAd";

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public static RewardAd CreateRewardAdInstance() =>
            sJavaClass.CallStaticAsWrapper<RewardAd>("createRewardAdInstance", AndroidContext.ActivityContext);


        public RewardAd(AndroidJavaObject javaObject) : base(javaObject) { }

        public RewardAd(string paramString) : base("com.huawei.hms.ads.reward.RewardAd", AndroidContext.ActivityContext, paramString)
        {
            AdId = paramString;
        }

        public string AdId { get; private set; }

        public Reward Reward => CallAsWrapper<Reward>("getReward");

        public bool Loaded => Call<bool>("isLoaded");

        public void LoadAd(AdParam paramAdParam, Action onSuccess, Action<int> onError)
        {
            var listener = new LoadAdListener(onSuccess, onError);
            Call("loadAd", paramAdParam, new RewardAdLoadListener(listener));
        }

        public void LoadAd(AdParam paramAdParam)
        {
            LoadAd(AdId, paramAdParam);
        }

        public Task LoadAdAsync(AdParam paramAdParam)
        {
            var task = new TaskCompletionSource<int>();
            LoadAd(paramAdParam, () => task.SetResult(0), (errorCode) =>
            {
                var error = new HMSException(errorCode);
                task.SetException(error);
            });
            return task.Task;
        }

        public void SetRewardVerifyConfig(RewardVerifyConfig config) => Call("setRewardVerifyConfig", config);

        public IOnMetadataChangedListener OnMetadataChangedListener
        {
            set
            {
                Call("setOnMetadataChangedListener", new OnMetadataChangedListener(value));
            }
        }

        public void Show(IRewardAdStatusListener paramRewardAdStatusListener, bool paramBoolean) =>
            Call("show", AndroidContext.ActivityContext, new RewardAdStatusListener(paramRewardAdStatusListener), paramBoolean);

        public void Show(IRewardAdStatusListener paramRewardAdStatusListener) =>
            Call("show", AndroidContext.ActivityContext, new RewardAdStatusListener(paramRewardAdStatusListener));

        public RewardVerifyConfig RewardVerifyConfig => CallAsWrapper<RewardVerifyConfig>("getRewardVerifyConfig");

        public void Destroy() => Call("destroy", AndroidContext.ActivityContext);

        public IRewardAdListener RewardAdListener
        {
            set
            {
                Call("setRewardAdListener", new RewardAdListenerWrapper(value));
            }
        }

        public string Data => CallAsString("getData");

        public string UserId => CallAsString("getUserId");

        public void SetUserId(string paramString) => Call("setUserId", paramString);

        public void SetData(string paramString) => Call("setData", paramString);

        public void LoadAd(string paramString, AdParam paramAdParam) => Call("loadAd", paramString, paramAdParam);

        public void Pause() => Call("pause", AndroidContext.ActivityContext);

        public void Resume() => Call("resume", AndroidContext.ActivityContext);

        public bool Immersive => Call<bool>("isImmersive");

        public void Show() => Call("show", AndroidContext.ActivityContext);

        public void SetMobileDataAlertSwitch(bool alertSwitch) => Call("setMobileDataAlertSwitch", alertSwitch);

    }

}