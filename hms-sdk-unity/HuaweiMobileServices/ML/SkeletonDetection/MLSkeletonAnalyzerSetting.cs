
using HuaweiMobileServices.ML.LanguageDetection.Local;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.ML.SkeletonDetection
{
    public class MLSkeletonAnalyzerSetting : JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.skeleton.MLSkeletonAnalyzerSetting";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);
        public MLSkeletonAnalyzerSetting(AndroidJavaObject javaObject) : base(javaObject)
        {
        }

        public MLSkeletonAnalyzerSetting(string javaObjectCanonicalName, params object[] args) : base(javaObjectCanonicalName, args)
        {
        }

        public static int TYPE_NORMAL => sJavaClass.GetStatic<int>(nameof(TYPE_NORMAL));
        public static int TYPE_YOGA => sJavaClass.GetStatic<int>(nameof(TYPE_YOGA));



        public class Factory : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.mlsdk.skeleton.MLSkeletonAnalyzerSetting$Factory";
            public Factory(AndroidJavaObject javaObject) : base(javaObject) { }
            public Factory() : base(CLASS_NAME) { }

            public MLSkeletonAnalyzerSetting Create() => CallAsWrapper<MLSkeletonAnalyzerSetting>("create");

            public Factory SetAnalyzerType(int analyzerType) => CallAsWrapper<Factory>("setAnalyzerType", analyzerType);

        }

    }
}
