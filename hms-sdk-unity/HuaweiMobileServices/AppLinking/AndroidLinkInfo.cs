using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.AppLinking
{
    public class AndroidLinkInfo : JavaObjectWrapper
    {
        public AndroidLinkInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.applinking.AppLinking$AndroidLinkInfo");

        public AndroidLinkInfo() : base("com.huawei.agconnect.applinking.AppLinking$AndroidLinkInfo") { }

        public static Builder NewBuilder() => javaClass.CallStaticAsWrapper<Builder>("newBuilder");

        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.agconnect.applinking.AppLinking$AndroidLinkInfo$Builder") { }

            public Builder(string packageName) : base("com.huawei.agconnect.applinking.AppLinking$AndroidLinkInfo$Builder") { }

            public AndroidLinkInfo Build() => CallAsWrapper<AndroidLinkInfo>("build");

            public Builder SetAndroidDeepLink(string androidDeepLink) => CallAsWrapper<Builder>("setAndroidDeepLink", androidDeepLink.AsJavaString());

            public Builder SetOpenType(AndroidOpenType androidDeepLink) => CallAsWrapper<Builder>("setOpenType", AndroidOpenTypeWrapper.GetLinkingPreviewType(androidDeepLink));

            public Builder SetFallbackUrl(string fallbackUrl) => CallAsWrapper<Builder>("setFallbackUrl", fallbackUrl.AsJavaString());

            public Builder SetMinimumVersion(int minimumVersion) => CallAsWrapper<Builder>("setMinimumVersion", minimumVersion);

        }

        public class AndroidOpenTypeWrapper : JavaObjectWrapper
        {
            public AndroidOpenTypeWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

            private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.applinking.AppLinking$AndroidLinkInfo$AndroidOpenType");

            public static readonly AndroidOpenTypeWrapper AppGallery = javaClass.GetStaticAsWrapper<AndroidOpenTypeWrapper>("AppGallery");
            public static readonly AndroidOpenTypeWrapper LocalMarket = javaClass.GetStaticAsWrapper<AndroidOpenTypeWrapper>("LocalMarket");
            public static readonly AndroidOpenTypeWrapper CustomUrl = javaClass.GetStaticAsWrapper<AndroidOpenTypeWrapper>("CustomUrl");


            public static AndroidOpenTypeWrapper GetLinkingPreviewType(AndroidOpenType androidOpenType)
            {
                if (androidOpenType == 0) return AppGallery;
                else if ((int)androidOpenType == 1) return LocalMarket;
                else return CustomUrl;
            }
        }
        public enum AndroidOpenType
        {
            AppGallery = 0,
            LocalMarket = 1,
            CustomUrl = 2
        }
    }
}
