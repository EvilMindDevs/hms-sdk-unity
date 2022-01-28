using System.Collections.Generic;

namespace HuaweiMobileServices.Ads
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.ads.Adparam
    public class AdParam : JavaObjectWrapper
    {


        public AdParam(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string TargetingContentUrl => CallAsString("getTargetingContentUrl");

        public int Gender => Call<int>("getGender");

        public ISet<string> Keywords => Call<AndroidJavaObject>("getKeywords").AsStringSet();

        // Wrapper for com.huawei.hms.ads.Adparam.Builder
        public class Builder : JavaObjectWrapper
        {


            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.ads.AdParam$Builder") { }

            public Builder AddKeyword(string param1String) => CallAsWrapper<Builder>("addKeyword", param1String);

            public AdParam Build() => CallAsWrapper<AdParam>("build");

            public Builder SetTargetingContentUrl(string param1String) => CallAsWrapper<Builder>("setTargetingContentUrl", param1String);

            public Builder SetGender(int param1Int) => CallAsWrapper<Builder>("setGender", param1Int);

            public Builder SetRequestOrigin(string param1String) => CallAsWrapper<Builder>("setRequestOrigin", param1String);

            public Builder SetBelongCountryCode(string param1String) => CallAsWrapper<Builder>("setBelongCountryCode", param1String);

            public Builder SetTagForChildProtection(int param1Integer) => CallAsWrapper<Builder>("setTagForChildProtection", param1Integer.AsJavaInteger());

            public Builder SetNonPersonalizedAd(int param1Integer) => CallAsWrapper<Builder>("setNonPersonalizedAd", param1Integer.AsJavaInteger());

            public Builder SetAppLang(string param1String) => CallAsWrapper<Builder>("setAppLang", param1String);

            public Builder SetAppCountry(string param1String) => CallAsWrapper<Builder>("setAppCountry", param1String);

            public Builder SetTagForUnderAgeOfPromise(int param1Integer) => CallAsWrapper<Builder>("setTagForUnderAgeOfPromise", param1Integer.AsJavaInteger());

            public Builder SetAdContentClassification(string param1String) => CallAsWrapper<Builder>("setAdContentClassification", param1String);

            public Builder SetConsent(string param1String) => CallAsWrapper<Builder>("setConsent", param1String);

            public Builder SetContentBundle(string contentBundle) => CallAsWrapper<Builder>("setContentBundle", contentBundle);
        }

        public static class ErrorCode
        {
            public static int INNER = 0;

            public static int INVALID_REQUEST = 1;

            public static int NETWORK_ERROR = 2;

            public static int NO_AD = 3;

            public static int AD_LOADING = 4;

            public static int LOW_API = 5;

            public static int BANNER_AD_EXPIRE = 6;

            public static int BANNER_AD_CANCEL = 7;

            public static int HMS_NOT_SUPPORT_SET_APP = 8;
        }
    }

}