namespace HuaweiMobileServices.Ads
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.ads.BannerAdSize
    public class BannerAdSize : JavaObjectWrapper
    {

        private const string CLASS_NAME = "com.huawei.hms.ads.BannerAdSize";

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public static BannerAdSize BANNER_SIZE_360_57 => sJavaClass.GetStaticAsWrapper<BannerAdSize>("BANNER_SIZE_360_57");
        public static BannerAdSize BANNER_SIZE_360_144 => sJavaClass.GetStaticAsWrapper<BannerAdSize>("BANNER_SIZE_360_144");
        public static BannerAdSize BANNER_SIZE_320_50 => sJavaClass.GetStaticAsWrapper<BannerAdSize>("BANNER_SIZE_320_50");
        public static BannerAdSize BANNER_SIZE_DYNAMIC => sJavaClass.GetStaticAsWrapper<BannerAdSize>("BANNER_SIZE_DYNAMIC");
        public static BannerAdSize BANNER_SIZE_468_60 => sJavaClass.GetStaticAsWrapper<BannerAdSize>("BANNER_SIZE_468_60");
        public static BannerAdSize BANNER_SIZE_INVALID => sJavaClass.GetStaticAsWrapper<BannerAdSize>("BANNER_SIZE_INVALID");
        public static BannerAdSize BANNER_SIZE_320_100 => sJavaClass.GetStaticAsWrapper<BannerAdSize>("BANNER_SIZE_320_100");
        public static BannerAdSize BANNER_SIZE_728_90 => sJavaClass.GetStaticAsWrapper<BannerAdSize>("BANNER_SIZE_728_90");
        public static BannerAdSize BANNER_SIZE_300_250 => sJavaClass.GetStaticAsWrapper<BannerAdSize>("BANNER_SIZE_300_250");
        public static BannerAdSize BANNER_SIZE_SMART => sJavaClass.GetStaticAsWrapper<BannerAdSize>("BANNER_SIZE_SMART");
        public static BannerAdSize BANNER_SIZE_160_600 => sJavaClass.GetStaticAsWrapper<BannerAdSize>("BANNER_SIZE_160_600");

        public static BannerAdSize GetCurrentDirectionBannerSize(int paramInt) =>
            sJavaClass.CallStaticAsWrapper<BannerAdSize>("getCurrentDirectionBannerSize", AndroidContext.ActivityContext, paramInt);

        public static BannerAdSize GetLandscapeBannerSize(int paramInt) =>
            sJavaClass.CallStaticAsWrapper<BannerAdSize>("getLandscapeBannerSize", AndroidContext.ActivityContext, paramInt);

        public static BannerAdSize GetPortraitBannerSize(int paramInt) =>
            sJavaClass.CallStaticAsWrapper<BannerAdSize>("getPortraitBannerSize", AndroidContext.ActivityContext, paramInt);


        [UnityEngine.Scripting.Preserve]
        public BannerAdSize(AndroidJavaObject javaObject) : base(javaObject) { }

        public int Height => Call<int>("getHeight");

        public int Width => Call<int>("getWidth");

        public int HeightPx => Call<int>("getHeightPx", AndroidContext.ActivityContext);

        public int WidthPx => Call<int>("getWidthPx", AndroidContext.ActivityContext);

        public bool AutoHeightSize => Call<bool>("isAutoHeightSize");

        public bool DynamicSize => Call<bool>("isDynamicSize");

        public bool FullWidthSize => Call<bool>("isFullWidthSize");
    }
}
