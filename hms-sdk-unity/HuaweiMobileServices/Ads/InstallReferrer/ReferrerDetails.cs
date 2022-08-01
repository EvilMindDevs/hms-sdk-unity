namespace HuaweiMobileServices.Ads.InstallReferrer
{
    using HuaweiMobileServices.Utils;

    using System.Collections;
    using System.Collections.Generic;

    using UnityEngine;

    public class ReferrerDetails : JavaObjectWrapper
    {
        public ReferrerDetails(AndroidJavaObject javaObject) : base(javaObject) { }

        public long getInstallBeginTimestampMillisecond() => Call<long>("getInstallBeginTimestampMillisecond");
        public long getReferrerClickTimestampMillisecond() => Call<long>("getReferrerClickTimestampMillisecond");
        public string getInstallReferrer() => Call<string>("getInstallReferrer");
    }
}