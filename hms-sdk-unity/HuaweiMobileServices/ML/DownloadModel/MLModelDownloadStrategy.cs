using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.ML.DownloadModel
{
    // Wrapper for com.huawei.hms.mlsdk.model.download.MLModelDownloadStrategy
    // https://developer.huawei.com/consumer/en/doc/hiai-References/mlmodeldownloadstrategy-0000001050204147
    public class MLModelDownloadStrategy : JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.model.download.MLModelDownloadStrategy";
        public MLModelDownloadStrategy(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public static int REGION_DR_CHINA => sJavaClass.GetStatic<int>(nameof(REGION_DR_CHINA));
        public static int REGION_DR_AFILA => sJavaClass.GetStatic<int>(nameof(REGION_DR_AFILA));
        public static int REGION_DR_EUROPE => sJavaClass.GetStatic<int>(nameof(REGION_DR_EUROPE));
        public static int REGION_DR_RUSSIA => sJavaClass.GetStatic<int>(nameof(REGION_DR_RUSSIA));
        public static int REGION_DR_GERMAN => sJavaClass.GetStatic<int>(nameof(REGION_DR_GERMAN));
        public static int REGION_DR_SINGAPORE => sJavaClass.GetStatic<int>(nameof(REGION_DR_SINGAPORE));

        public bool IsChargingNeed => Call<bool>("isChargingNeed");
        public bool IsWifiNeed => Call<bool>("isWifiNeed");
        public bool IsDeviceIdleNeed => Call<bool>("isDeviceIdleNeed");
        public string GetRegion() => Call<string>("getRegion");

        public class Factory : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.mlsdk.model.download.MLModelDownloadStrategy$Factory";
            public Factory(AndroidJavaObject javaObject) : base(javaObject) { }
            public Factory() : base(CLASS_NAME) { }
            public MLModelDownloadStrategy Create() => CallAsWrapper<MLModelDownloadStrategy>("create");
            public Factory NeedCharging() => CallAsWrapper<Factory>("needCharging");
            public Factory NeedDeviceIdle() => CallAsWrapper<Factory>("needDeviceIdle");
            public Factory NeedWifi() => CallAsWrapper<Factory>("needWifi");
            /// <summary>
            /// Set the region for downloading the model.
            /// </summary>
            /// <param name="region">
            ///   REGION_DR_CHINA
            ///   REGION_DR_AFILA
            ///   REGION_DR_EUROPE
            ///   REGION_DR_RUSSIA
            ///   REGION_DR_GERMAN
            ///   REGION_DR_SINGAPORE
            /// </param>
            /// <returns></returns>
            public Factory SetRegion(int region) => CallAsWrapper<Factory>("setRegion", region);
        }

    }
}
