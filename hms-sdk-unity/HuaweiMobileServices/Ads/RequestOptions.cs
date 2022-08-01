namespace HuaweiMobileServices.Ads
{

    using HuaweiMobileServices.Utils;

    using UnityEngine;

    // Wrapper for com.huawei.hms.ads.RequestOptions
    public class RequestOptions : JavaObjectWrapper
    {

        public RequestOptions(AndroidJavaObject javaObject) : base(javaObject) { }

        public int TagForChildProtection => Call<int>("getTagForChildProtection");

        public int TagForUnderAgeOfPromise => Call<int>("getTagForUnderAgeOfPromise");

        public int NonPersonalizedAd => Call<AndroidJavaObject>("getNonPersonalizedAd").AsInt();

        public string AppLang => CallAsString("getAppLang");

        public string AppCountry => CallAsString("getAppCountry");

        public string AdContentClassification => CallAsString("getAdContentClassification");

        public string Consent => CallAsString("getConsent");

        public Builder ToBuilder() => CallAsWrapper<Builder>("toBuilder");

        public class Builder : JavaObjectWrapper
        {


            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public RequestOptions Build() => CallAsWrapper<RequestOptions>("build");

            public Builder SetTagForChildProtection(int Param1Integer) => CallAsWrapper<Builder>("setTagForChildProtection", Param1Integer.AsJavaInteger());

            public Builder SetTagForUnderAgeOfPromise(int Param1Integer) => CallAsWrapper<Builder>("setTagForUnderAgeOfPromise", Param1Integer.AsJavaInteger());

            public Builder SetAdContentClassification(string Param1String) => CallAsWrapper<Builder>("setAdContentClassification", Param1String);

            public Builder SetNonPersonalizedAd(int Param1Integer) => CallAsWrapper<Builder>("setNonPersonalizedAd", Param1Integer.AsJavaInteger());

            public Builder SetAppLang(string Param1String) => CallAsWrapper<Builder>("setAppLang", Param1String);

            public Builder SetAppCountry(string Param1String) => CallAsWrapper<Builder>("setAppCountry", Param1String);

            public Builder SetConsent(string Param1String) => CallAsWrapper<Builder>("setConsent", Param1String);

            public Builder SetRequestLocation(bool requestLocation) => CallAsWrapper<Builder>("setRequestLocation", requestLocation.AsJavaBoolean());

        }
    }
}
