namespace HuaweiMobileServices.Ads
{

    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.ads.RequestOptions
    public class RequestOptions : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public RequestOptions(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual int? TagForChildProtection => Call<int?>("getTagForChildProtection");

        public virtual int? TagForUnderAgeOfPromise => Call<int?>("getTagForUnderAgeOfPromise");

        public virtual int? NonPersonalizedAd => Call<int?>("getNonPersonalizedAd");

        public virtual string AppLang => CallAsString("getAppLang");

        public virtual string AppCountry => CallAsString("getAppCountry");

        public virtual string AdContentClassification => CallAsString("getAdContentClassification");

        public virtual Builder ToBuilder() => CallAsWrapper<Builder>("toBuilder");

        public class Builder : JavaObjectWrapper
        {

            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public virtual RequestOptions Build() => CallAsWrapper<RequestOptions>("build");

            public virtual Builder SetTagForChildProtection(int? Param1Integer) => CallAsWrapper<Builder>("setTagForChildProtection", Param1Integer?.AsJavaInteger());

            public virtual Builder SetTagForUnderAgeOfPromise(int? Param1Integer) => CallAsWrapper<Builder>("setTagForUnderAgeOfPromise", Param1Integer?.AsJavaInteger());

            public virtual Builder SetAdContentClassification(string Param1String) => CallAsWrapper<Builder>("setAdContentClassification", Param1String);

            public virtual Builder SetNonPersonalizedAd(int? Param1Integer) => CallAsWrapper<Builder>("setNonPersonalizedAd", Param1Integer?.AsJavaInteger());

            public virtual Builder SetAppLang(string Param1String) => CallAsWrapper<Builder>("setAppLang", Param1String);

            public virtual Builder SetAppCountry(string Param1String) => CallAsWrapper<Builder>("setAppCountry", Param1String);

        }
    }
}
