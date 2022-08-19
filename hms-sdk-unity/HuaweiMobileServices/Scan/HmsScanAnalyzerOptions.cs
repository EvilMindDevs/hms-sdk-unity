using HuaweiMobileServices.Utils;

using UnityEngine;

namespace HuaweiMobileServices.Scan
{
    public class HmsScanAnalyzerOptions : JavaObjectWrapper
    {
        public HmsScanAnalyzerOptions(AndroidJavaObject javaObject) : base(javaObject) { }
        public HmsScanAnalyzerOptions() : base("com.huawei.hms.ml.scan.HmsScanAnalyzerOptions") { }

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ml.scan.HmsScanAnalyzerOptions");
        public bool Equals(object obj) => Call<bool>("equals", obj);
        public int HashCode() => Call<int>("hashCode");

        public class Creator : JavaObjectWrapper
        {
            private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.scan.bridge.ScanKitBridge");
            public Creator(AndroidJavaObject javaObject) : base(javaObject) { }
            public Creator() : base("com.huawei.hms.ml.scan.HmsScanAnalyzerOptions$Creator") { }
            public HmsScanAnalyzerOptions Create() => CallAsWrapper<HmsScanAnalyzerOptions>("create");
            public Creator setPhotoMode(bool mode) => CallAsWrapper<Creator>("setPhotoMode", mode);
            public static Creator SetHmsScanTypes(int var1, Creator creator) => sJavaClass.CallStaticAsWrapper<Creator>("processCreator", creator.JavaObject, var1);
        }
    }
}