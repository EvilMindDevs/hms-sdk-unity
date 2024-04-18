using HuaweiMobileServices.Utils;
using UnityEngine;


namespace HuaweiMobileServices.ML.Common
{
    //https://developer.huawei.com/consumer/en/doc/hiai-References/mlapplication-0000001050167420
    public class MLApplication: JavaObjectWrapper
    {
        const string CLASS_NAME = "com.huawei.hms.mlsdk.common.MLApplication";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public MLApplication(AndroidJavaObject javaObject) : base(javaObject) {}

        public static int REGION_DR_UNKNOWN => sJavaClass.GetStatic<int>(nameof(REGION_DR_UNKNOWN));

        public static int REGION_DR_CHINA => sJavaClass.GetStatic<int>(nameof(REGION_DR_CHINA));

        public static int REGION_DR_RUSSIA => sJavaClass.GetStatic<int>(nameof(REGION_DR_RUSSIA));

        public static int REGION_DR_GERMAN => sJavaClass.GetStatic<int>(nameof(REGION_DR_GERMAN));


        public static MLApplication Instance => sJavaClass.CallStaticAsWrapper<MLApplication>("getInstance");
        public static MLApplication Initialize() => sJavaClass.CallStaticAsWrapper<MLApplication>("initialize", AndroidContext.ActivityContext);
        public void SetApiKey(string apiKey) => Call("setApiKey", apiKey);
        public void SetUserRegion(int region) => Call("setUserRegion", region.AsJavaInteger());
        public void SetAccessToken(string serviceUrl) => Call("setAccessToken", serviceUrl);
        public string GetCountryCode() => Call<string>("getCountryCode");



    }
}
