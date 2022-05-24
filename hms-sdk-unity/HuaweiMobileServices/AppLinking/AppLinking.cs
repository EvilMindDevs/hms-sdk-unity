using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.AppLinking
{
    public class AppLinking : JavaObjectWrapper
    {

        public AppLinking(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.agconnect.applinking.AppLinking");

        public string GetUri => CallAsUriString("getUri");
        public Builder NewBuilder => CallAsWrapper<Builder>("newBuilder");
        //public string GetResourceUri() => Call<string>("getResourceUri");

        // Wrapper for com.huawei.agconnect.applinking.AppLinking$Builder
        public class Builder : JavaObjectWrapper
        {

            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.agconnect.applinking.AppLinking$Builder") { }

            public AppLinking BuildAppLinking() => CallAsWrapper<AppLinking>("buildAppLinking");

            public ITask<ShortAppLinking> BuildShortAppLinking() => CallAsWrapper<TaskJavaObjectWrapper<ShortAppLinking>>("buildShortAppLinking");

            public ITask<ShortAppLinking> BuildShortAppLinking(ShortAppLinking.LENGTH length) => CallAsWrapper<TaskJavaObjectWrapper<ShortAppLinking>>("buildShortAppLinking", length);

            public Builder SetAndroidLinkInfo(AndroidLinkInfo androidLinkInfo) => CallAsWrapper<Builder>("setAndroidLinkInfo");

            public Builder SetDeepLink(string deepLink) => CallAsWrapper<Builder>("setDeepLink", deepLink.AsJavaString()); //todo check

            public Builder SetLongLink(string longLink) => CallAsWrapper<Builder>("setLongLink", longLink.AsJavaString()); //todo check

            public Builder SetSocialCardInfo(SocialCardInfo socialCardInfo) => CallAsWrapper<Builder>("setSocialCardInfo", socialCardInfo);

            public Builder SetCampaignInfo(CampaignInfo campaignInfo) => CallAsWrapper<Builder>("setCampaignInfo", campaignInfo);

            public Builder SetUriPrefix(string uriPrefix) => CallAsWrapper<Builder>("setUriPrefix", uriPrefix.AsJavaString());

            public Builder SetExpireMinute(long expireMinute) => CallAsWrapper<Builder>("setExpireMinute", expireMinute);

            public Builder SetPreviewType(LinkingPreviewType previewType) => CallAsWrapper<Builder>("setPreviewType", previewType);

            public Builder SetIsShowPreview(bool isShowPreview) => CallAsWrapper<Builder>("setIsShowPreview", isShowPreview);

        }

        public enum LinkingPreviewType
        {
            AppInfo,
            SocialInfo
        }

    }

}
