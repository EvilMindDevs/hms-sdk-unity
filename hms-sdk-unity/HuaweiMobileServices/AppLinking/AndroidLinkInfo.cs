using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.AppLinking
{
    public class AndroidLinkInfo : JavaObjectWrapper
    {
        public AndroidLinkInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidLinkInfo() : base("com.huawei.agconnect.applinking.AppLinking$AndroidLinkInfo") { }

        public Builder NewBuilder => CallAsWrapper<Builder>("newBuilder");

        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.agconnect.applinking.AppLinking$AndroidLinkInfo") { }

            public Builder(string packageName) : base("com.huawei.agconnect.applinking.AppLinking$AndroidLinkInfo") { }

            public AndroidLinkInfo Build() => CallAsWrapper<AndroidLinkInfo>("build");

            public Builder SetAndroidDeepLink(string androidDeepLink) => CallAsWrapper<Builder>("setAndroidDeepLink", androidDeepLink.AsJavaString());

            public Builder SetOpenType(AndroidOpenType androidDeepLink) => CallAsWrapper<Builder>("setOpenType", androidDeepLink);

            public Builder SetFallbackUrl(string fallbackUrl) => CallAsWrapper<Builder>("setFallbackUrl", fallbackUrl.AsJavaString());

            public Builder SetMinimumVersion(int minimumVersion) => CallAsWrapper<Builder>("setMinimumVersion", minimumVersion);

        }
        public enum AndroidOpenType
        {
            AppGallery,
            LocalMarket,
            CustomUrl
        }
    }
}
