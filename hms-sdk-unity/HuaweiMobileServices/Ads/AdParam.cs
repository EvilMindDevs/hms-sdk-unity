using System.Collections.Generic;

namespace HuaweiMobileServices.Ads
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.ads.Adparam
    public class AdParam : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public AdParam(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string TargetingContentUrl => CallAsString("getTargetingContentUrl");

        public int Gender => Call<int>("getGender");

        public ISet<string> Keywords => Call<AndroidJavaObject>("getKeywords").AsStringSet();

        // Wrapper for com.huawei.hms.ads.Adparam.Builder
        public class Builder : JavaObjectWrapper
        {

            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.ads.AdParam$Builder") { }

            public Builder AddKeyword(string param1String)
            {
                JavaObject = Call<AndroidJavaObject>("addKeyword", param1String);
                return this;
            }

            public AdParam Build() => CallAsWrapper<AdParam>("build");

            public Builder SetTargetingContentUrl(string param1String)
            {
                JavaObject = Call<AndroidJavaObject>("setTargetingContentUrl", param1String);
                return this;
            }

            public Builder SetGender(int param1Int)
            {
                JavaObject = Call<AndroidJavaObject>("setGender", param1Int);
                return this;
            }

            public Builder SetRequestOrigin(string param1String)
            {
                JavaObject = Call<AndroidJavaObject>("setRequestOrigin", param1String);
                return this;
            }

            public Builder SetBelongCountryCode(string param1String)
            {
                JavaObject = Call<AndroidJavaObject>("setBelongCountryCode", param1String);
                return this;
            }

            public Builder SetTagForChildProtection(int? param1Integer)
            {
                JavaObject = Call<AndroidJavaObject>("setTagForChildProtection", param1Integer);
                return this;
            }

            public Builder SetNonPersonalizedAd(int? param1Integer)
            {
                JavaObject = Call<AndroidJavaObject>("setNonPersonalizedAd", param1Integer);
                return this;
            }

            public Builder SetAppLang(string param1String)
            {
                JavaObject = Call<AndroidJavaObject>("setAppLang", param1String);
                return this;
            }

            public Builder SetAppCountry(string param1String)
            {
                JavaObject = Call<AndroidJavaObject>("setAppCountry", param1String);
                return this;
            }

            public Builder SetTagForUnderAgeOfPromise(int? param1Integer)
            {
                JavaObject = Call<AndroidJavaObject>("setTagForUnderAgeOfPromise", param1Integer);
                return this;
            }

            public Builder SetAdContentClassification(string param1String)
            {
                JavaObject = Call<AndroidJavaObject>("setAdContentClassification", param1String);
                return this;
            }
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
        }
    }

}