using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.Ads.NativeAd
{
    public class NativeAd : JavaObjectWrapper
    {
        //wrapper for com.huawei.hms.ads.nativead.NativeAd
        //https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/nativead-0000001050066855

        public NativeAd(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ads.nativead.NativeAd");

        public static explicit operator NativeAd(AndroidJavaObject v) => new NativeAd(v);

        public string Title
        {
            get => Call<string>("getTitle");
        }

        public IList<Image> Images
        {
            get => CallAsWrapperList<Image>("getImages");
        }

        public Video Video
        {
            get => CallAsWrapper<Video>("getVideo");
        }

        public string Description
        {
            get => Call<string>("getDescription");
        }

        public Image Icon
        {
            get => CallAsWrapper<Image>("getIcon");
        }

        public string CallToAction
        {
            get => Call<string>("getCallToAction");
        }

        public string AdSource
        {
            get => Call<string>("getAdSource");
        }

        public double Rating
        {
            get => (double)Call<AndroidJavaObject>("getRating").AsDouble();
        }

        public string Market
        {
            get => Call<string>("getMarket");
        }

        public string Price
        {
            get => Call<string>("getPrice");
        }

        public VideoOperator VideoOperator
        {
            get => Call<VideoOperator>("getVideoOperator");
        }

        //method for getting ChoicesInfo Nested Class
        public NativeAd.ChoicesInfo GetChoicesInfo()
        {
            return Call<NativeAd.ChoicesInfo>("getChoicesInfo");
        }

        public bool IsCustomDislikeThisAdEnabled() => Call<bool>("isCustomDislikeThisAdEnabled");

        /*public IList<DislikeAdReason> DislikeAdReasons
        {
            get => Call<DislikeAdReason>("getDislikeAdReasons");
        }*/

        public void DislikeAd(DislikeAdReason reason) => Call("dislikeAd", reason);

        public void SetDislikeAdListener(DislikeAdListener listener) => Call("setAdListener", listener);

        public Bundle ExtraBundle 
        {
            get => CallAsWrapper<Bundle>("getExtraBundle");
        }

        public void Destroy() => Call("destroy");

        public void SetAllowCustomClick() => Call("setAllowCustomClick");

        public bool IsCustomClickAllowed() => Call<bool>("isCustomClickAllowed");

        public void RecordClickEvent() => Call("recordClickEvent");

        public void TriggerClick(Bundle bundle) => Call("triggerClick", bundle);

        public bool RecordImpressionEvent(Bundle data) => Call<bool>("recordImpressionEvent", data);

        public bool RecordClickEvent(Bundle data) => Call<bool>("recordClickEvent", data);

        public void RecordTouchEvent(Bundle bundle) => Call("recordTouchEvent", bundle);

        /*public MediaContent MediaContent //is this needed?
        {
            get => Call<MediaContent>("getMediaContent");
        }*/

        public int CreativeType
        {
            get => Call<int>("getCreativeType");
        }

        public string UniqueId
        {
            get => Call<string>("getUniqueId");
        }

        public void OnAdClose(IList<string> keyWords) => Call("onAdClose", AndroidContext.ActivityContext, keyWords);

        public bool RecordShowStartEvent(Bundle data) => Call<bool>("recordShowStartEvent", data);

        public void GotoWhyThisAdPage() => Call("gotoWhyThisAdPage", AndroidContext.ActivityContext);

        public string AdSign
        {
            get => Call<string>("getAdSign");
        }

        public string WhyThisAdRedirectionLink
        {
            get => Call<string>("getWhyThisAd");
        }

        public void SetAutoDownloadApp(bool value) => Call("setAutoDownloadApp", value);

        public bool IsAutoDownloadApp() => Call<bool>("isAutoDownloadApp");

        public void SetRewardVerifyConfig(RewardVerifyConfig config) => Call("setRewardVerifyConfig", config);

        public Map<string, string> Ext 
        {
            get => CallAsWrapper<Map<string, string>>("getExt");
        }

        //public void setAdFeedbackListener(AdFeedbackListener var1) => Call("setAdFeedbackListener", var1);

        public string DspName
        {
            get => Call<string>("getDspName");
        }

        public string DspLogo
        {
            get => Call<string>("getDspLogo");
        }

        public string AbilityDetailInfo
        {
            get => Call<string>("getAbilityDetailInfo");
        }

        public string HwChannelId
        {
            get => Call<string>("getHwChannelId");
        }

        public class ChoicesInfo : JavaObjectWrapper
        {
            public ChoicesInfo(AndroidJavaObject javaObject) : base(javaObject) { }

            public ChoicesInfo() : base("com.huawei.hms.ads.nativead.NativeAd$ChoicesInfo", AndroidContext.ActivityContext) { }

            public string Content
            {
                get => Call<string>("getContent");
            }

           public IList<Image> Icons
            {
                get => CallAsWrapperList<Image>("getIcons");
            }

        }
    }
}
