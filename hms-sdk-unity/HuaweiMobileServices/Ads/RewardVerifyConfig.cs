namespace HuaweiMobileServices.Ads
{
    using HuaweiMobileServices.Ads.InstallReferrer;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.ads.reward.RewardVerifyConfig
    public class RewardVerifyConfig : JavaObjectWrapper
    {
        public RewardVerifyConfig(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string Data => CallAsString("getData");

        public virtual string UserId => CallAsString("getUserId");

        // Wrapper for com.huawei.hms.ads.reward.RewardVerifyConfig.Builder
        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }
            public Builder() : base("com.huawei.hms.ads.reward.RewardVerifyConfig$Builder") { }
            public Builder SetData(string data) => CallAsWrapper<Builder>("setData", data);
            public Builder SetUserId(string userId) => CallAsWrapper<Builder>("setUserId", userId);
            public RewardVerifyConfig Build() => CallAsWrapper<RewardVerifyConfig>("build");
        }
    }

}