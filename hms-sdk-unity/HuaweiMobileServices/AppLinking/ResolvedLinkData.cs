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

        public LinkType GetLinkType() => AGConnectAppLinking.GetLinkType(this);

        public string GetInstallSource() => Call<string>("getInstallSource");

        public enum LinkType
        {
            AppLinking,
            UnifiedLinking
        }
    }
}
