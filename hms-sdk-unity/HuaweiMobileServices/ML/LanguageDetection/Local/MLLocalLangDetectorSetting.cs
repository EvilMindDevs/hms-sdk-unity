using HuaweiMobileServices.ML.Translate.Local;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.ML.LanguageDetection.Local
{
    public class MLLocalLangDetectorSetting : JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.langdetect.local.MLLocalLangDetectorSetting";
        public MLLocalLangDetectorSetting(AndroidJavaObject javaObject) : base(javaObject) { }

        public float GetTrustedThreshold() => Call<float>("getTrustedThreshold");

        public override bool Equals(object obj) => Call<bool>("equals", obj);

        public override int GetHashCode() => Call<int>("hashCode");

        public class Factory : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.mlsdk.langdetect.local.MLLocalLangDetectorSetting$Factory";
            public Factory(AndroidJavaObject javaObject) : base(javaObject) { }
            public Factory() : base(CLASS_NAME) { }

            public MLLocalLangDetectorSetting Create() => CallAsWrapper<MLLocalLangDetectorSetting>("create");

            public Factory SetTrustedThreshold(float trustedThreshold) => CallAsWrapper<Factory>("setTrustedThreshold", trustedThreshold);

        }

    }
}
