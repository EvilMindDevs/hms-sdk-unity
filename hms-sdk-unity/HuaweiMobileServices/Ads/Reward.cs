using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Ads
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.ads.reward.Reward
    public class Reward : JavaObjectWrapper
    {

        public Reward(AndroidJavaObject javaObject) : base(javaObject) { }

        public string Name => CallAsString("getName");

        public int Amount => Call<int>("getAmount");

    }
}
