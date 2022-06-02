using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.AppLinking
{
    public class AppLinking : JavaObjectWrapper
    {

        public AppLinking(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.applinking.AppLinking");

        public string GetUri() => CallAsUriString("getUri");

        public static Builder NewBuilder() => javaClass.CallStaticAsWrapper<Builder>("newBuilder");

        //public string GetResourceUri() => Call<string>("getResourceUri");

        // Wrapper for com.huawei.agconnect.applinking.AppLinking$Builder
        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.agconnect.applinking.AppLinking$Builder") { }

            public AppLinking BuildAppLinking() => CallAsWrapper<AppLinking>("buildAppLinking");

            public ITask<ShortAppLinking> BuildShortAppLinking() => CallAsWrapper<TaskJavaObjectWrapper<ShortAppLinking>>("buildShortAppLinking");

            public ITask<ShortAppLinking> BuildShortAppLinking(ShortAppLinking.LENGTH length) => CallAsWrapper<TaskJavaObjectWrapper<ShortAppLinking>>("buildShortAppLinking", ShortAppLinking.LenghtWrapper.GetLinkingPreviewType(length));

            public Builder SetAndroidLinkInfo(AndroidLinkInfo androidLinkInfo) => CallAsWrapper<Builder>("setAndroidLinkInfo", androidLinkInfo);

            public Builder SetDeepLink(string deepLink) => CallAsWrapper<Builder>("setDeepLink", deepLink.AsJavaUri());

            public Builder SetLongLink(string longLink) => CallAsWrapper<Builder>("setLongLink", longLink.AsJavaUri());

            public Builder SetSocialCardInfo(SocialCardInfo socialCardInfo) => CallAsWrapper<Builder>("setSocialCardInfo", socialCardInfo);

            public Builder SetCampaignInfo(CampaignInfo campaignInfo) => CallAsWrapper<Builder>("setCampaignInfo", campaignInfo);

            public Builder SetUriPrefix(string uriPrefix) => CallAsWrapper<Builder>("setUriPrefix", uriPrefix.AsJavaString());

            public Builder SetExpireMinute(long expireMinute) => CallAsWrapper<Builder>("setExpireMinute", expireMinute);

            public Builder SetPreviewType(LinkingPreviewType previewType) => CallAsWrapper<Builder>("setPreviewType", LinkingPreviewTypeWrapper.GetLinkingPreviewType(previewType));

            public Builder SetIsShowPreview(bool isShowPreview) => CallAsWrapper<Builder>("setIsShowPreview", isShowPreview);
        }

        public class LinkingPreviewTypeWrapper : JavaObjectWrapper
        {
            public LinkingPreviewTypeWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

            private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.applinking.AppLinking$LinkingPreviewType");

            public static readonly LinkingPreviewTypeWrapper AppInfo = javaClass.GetStaticAsWrapper<LinkingPreviewTypeWrapper>("AppInfo");
            public static readonly LinkingPreviewTypeWrapper SocialInfo = javaClass.GetStaticAsWrapper<LinkingPreviewTypeWrapper>("SocialInfo");


            public static LinkingPreviewTypeWrapper GetLinkingPreviewType(LinkingPreviewType linkingPreviewType)
            {
                if (linkingPreviewType == 0) return AppInfo;
                else return SocialInfo;
            }
        }
        public enum LinkingPreviewType
        {
            AppInfo = 0,
            SocialInfo = 1
        }

    }

}
