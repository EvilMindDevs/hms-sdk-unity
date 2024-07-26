using HuaweiMobileServices.ML.TextRecognition;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.ML.Common
{
    public class MLAnalyzerFactory : JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.MLAnalyzerFactory";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);
        public MLAnalyzerFactory() : base(CLASS_NAME) { }
        public MLAnalyzerFactory(AndroidJavaObject javaObject) : base(javaObject) { }

        public static MLAnalyzerFactory Instance => sJavaClass.CallStaticAsWrapper<MLAnalyzerFactory>("getInstance");

        public MLTextAnalyzer GetLocalTextAnalyzer() => CallAsWrapper<MLTextAnalyzer>("getLocalTextAnalyzer");

        public MLTextAnalyzer GetLocalTextAnalyzer(MLLocalTextSetting mLLocalTextSetting) => CallAsWrapper<MLTextAnalyzer>("getLocalTextAnalyzer", mLLocalTextSetting);

        public MLTextAnalyzer GetRemoteTextAnalyzer() => CallAsWrapper<MLTextAnalyzer>("getRemoteTextAnalyzer");

        public MLTextAnalyzer GetRemoteTextAnalyzer(MLRemoteTextSetting mLLocalTextSetting) => CallAsWrapper<MLTextAnalyzer>("getRemoteTextAnalyzer", mLLocalTextSetting);

        public bool IsStatisticsAllowed() => Call<bool>("isStatisticsAllowed");

    }
}
