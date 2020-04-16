using System;
using System.Collections.Generic;

namespace HuaweiMobileServices.Ads
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

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
            Call("loadAd", paramAdParam, new RewardAdLoadListenerWrapper(paramRewardAdLoadListener));

        public virtual OnMetadataChangedListener OnMetadataChangedListener
        {
            set
            {
                this.Code_Conflict = value;
            }
        }

        public virtual void Show(Activity ParamActivity, RewardAdStatusListener ParamRewardAdStatusListener, bool ParamBoolean)
        {
            
        }

        public virtual void Show(Activity ParamActivity, RewardAdStatusListener ParamRewardAdStatusListener)
        {
            Show(ParamActivity, ParamRewardAdStatusListener, true);
        }

        public virtual RewardVerifyConfig RewardVerifyConfig
        {
            set
            {
                this.C = value;
            }
        }

        public virtual void Destroy() => Call("destroy", AndroidContext.GetActivityContext());

        public virtual Bundle Metadata
        {
            get
            {
                return this.D;
            }
        }

        public virtual RewardAdListener RewardAdListener
        {
            get
            {
                return this.L;
            }
            set
            {
                this.L = value;
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