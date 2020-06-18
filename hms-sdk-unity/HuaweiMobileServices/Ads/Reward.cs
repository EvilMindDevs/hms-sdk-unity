namespace HuaweiMobileServices.Ads
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.ads.reward.Reward
    public class Reward : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public Reward(AndroidJavaObject javaObject) : base(javaObject) { }

        public string Name => CallAsString("getName");

        public int Amount => Call<int>("getAmount");

    }
}
