using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.AppLinking
{
    public class ResolvedLinkData : JavaObjectWrapper
    {
        public ResolvedLinkData(AndroidJavaObject javaObject) : base(javaObject) { }

        public ResolvedLinkData() : base("com.huawei.agconnect.applinking.ResolvedLinkData") { }

        public long GetClickTimestamp() => Call<long>("getClickTimestamp");

        public string GetDeepLink() => CallAsUriString("getDeepLink");

        public string Instance() => Call<string>("getInstance");

        public string GetSocialTitle() => Call<string>("getSocialTitle");

        public string GetSocialDescription() => Call<string>("getSocialDescription");

        public string GetSocialImageUrl() => Call<string>("getSocialImageUrl");

        public string GetCampaignName() => Call<string>("getCampaignName");

        public string GetCampaignMedium() => Call<string>("getCampaignMedium");

        public string GetCampaignSource() => Call<string>("getCampaignSource");

        public LinkType GetLinkType() => LinkTypeWrapper.GetLinkingPreviewType(CallAsWrapper<LinkTypeWrapper>("getLinkType"));

        public string GetInstallSource() => Call<string>("getInstallSource");

        public class LinkTypeWrapper : JavaObjectWrapper
        {
            public LinkTypeWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

            private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.applinking.ResolvedLinkData$LinkType");

            public static readonly LinkTypeWrapper AppLinking = javaClass.GetStaticAsWrapper<LinkTypeWrapper>("AppLinking");
            public static readonly LinkTypeWrapper UnifiedLinking = javaClass.GetStaticAsWrapper<LinkTypeWrapper>("UnifiedLinking");

            public static LinkType GetLinkingPreviewType(LinkTypeWrapper linkTypeWrapper)
            {
                if (linkTypeWrapper == AppLinking) return LinkType.AppLinking;
                else return LinkType.UnifiedLinking;
            }
        }

        public enum LinkType
        {
            AppLinking = 0,
            UnifiedLinking = 1
        }

    }
}
