namespace HuaweiMobileServices.Ads.InstallReferrer
{
    using HuaweiMobileServices.Utils;

    using UnityEngine;

    public class ReferrerDetails : JavaObjectWrapper
    {
        public ReferrerDetails(AndroidJavaObject javaObject) : base(javaObject) { }

        public long GetInstallBeginTimestampMillisecond() => Call<long>("getInstallBeginTimestampMillisecond");
        public long GetReferrerClickTimestampMillisecond() => Call<long>("getReferrerClickTimestampMillisecond");
        public string GetInstallReferrer() => Call<string>("getInstallReferrer");
    }
}