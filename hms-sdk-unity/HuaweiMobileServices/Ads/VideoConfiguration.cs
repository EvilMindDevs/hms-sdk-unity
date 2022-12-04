using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Ads
{
    public class VideoConfiguration : JavaObjectWrapper
    {
        //wrapper for com.huawei.hms.ads.VideoConfiguration
        //https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/videoconfiguration-0000001050066837

        public VideoConfiguration(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ads.VideoConfiguration");

        public int AudioFocusType
        {
            get => sJavaClass.Get<int>("getAudioFocusType");
        }

        public bool IsClickToFullScreenRequested() => Call<bool>("isClickToFullScreenRequested");

        public bool IsCustomizeOperateRequested() => Call<bool>("isCustomizeOperateRequested");

        public bool IsStartMuted() => Call<bool>("isStartMuted");

        //wrapper for com.huawei.hms.ads.VideoConfiguration.Builder
        //https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/videoconfiguration-builder-0000001050064890
        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.ads.VideoConfiguration$Builder", AndroidContext.ActivityContext) { }

            public VideoConfiguration Build() => CallAsWrapper<VideoConfiguration>("build");

            public Builder SetAudioFocusType(int audioFocusType) => CallAsWrapper<Builder>("setAudioFocusType", audioFocusType);

            public Builder SetClickToFullScreenRequested(bool clickToFullScreenRequested) => CallAsWrapper<Builder>("setClickToFullScreenRequested", clickToFullScreenRequested);

            public Builder SetCustomizeOperateRequested(bool customizeOperateRequested) => CallAsWrapper<Builder>("setCustomizeOperateRequested", customizeOperateRequested);

            public Builder SetStartMuted(bool startMuted) => CallAsWrapper<Builder>("setStartMuted", startMuted);

        }

    }
}