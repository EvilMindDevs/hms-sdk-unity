using HuaweiMobileServices.Scan;
using HuaweiMobileServices.Utils;

using UnityEngine;

public class HmsScanAnalyzer : JavaObjectWrapper
{
    public HmsScanAnalyzer(AndroidJavaObject javaObject) : base(javaObject) { }
    public HmsScanAnalyzer(HmsScanAnalyzerOptions options) : base("com.huawei.hms.ml.scan.HmsScanAnalyzer", options) { }

    private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ml.scan.HmsScanAnalyzer");

    //TODO : Set runnable these commands when ML kit has been integrated
    //SparseArray<HmsScan> analyseFrame(MLFrame frame) 
    //Task<List<HmsScan>> analyzInAsyn(final MLFrame frame)
    public void Destroy() => Call("destroy");
    public bool IsAvailable() => Call<bool>("isAvailable");

    public class Creator : JavaObjectWrapper
    {
        public Creator(AndroidJavaObject javaObject) : base(javaObject) { }
        public Creator() : base("com.huawei.hms.ml.scan.HmsBuildBitmapOption$Creator", AndroidContext.ActivityContext) { }

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ml.scan.HmsBuildBitmapOption$Creator");

        public HmsScanAnalyzer Create() => CallAsWrapper<HmsScanAnalyzer>("create");
        public Creator SetHmsScanTypes(HmsScanAnalyzerOptions options) => CallAsWrapper<Creator>("setHmsScanTypes", options);
        public Creator SetHmsScanTypes(int format) => CallAsWrapper<Creator>("setHmsScanTypes", format);
    }

}
