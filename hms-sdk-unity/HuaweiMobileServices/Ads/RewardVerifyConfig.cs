namespace HuaweiMobileServices.Ads
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.ads.reward.RewardVerifyConfig
    public class RewardVerifyConfig : JavaObjectWrapper
    {

        public RewardVerifyConfig(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string Data => CallAsString("getData");

        public virtual string UserId => CallAsString("getUserId");

    }

}