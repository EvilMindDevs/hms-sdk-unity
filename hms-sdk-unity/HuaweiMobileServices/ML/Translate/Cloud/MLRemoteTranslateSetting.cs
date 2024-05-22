using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.ML.Translate.Cloud
{
    // Wrapper for com.huawei.hms.mlsdk.translate.cloud.MLRemoteTranslateSetting
    // https://developer.huawei.com/consumer/en/doc/hiai-References/mlremotetranslatesetting-0000001050167530

    public class MLRemoteTranslateSetting : JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.translate.cloud.MLRemoteTranslateSetting";
        public MLRemoteTranslateSetting(AndroidJavaObject javaObject) : base(javaObject) { }

        public MLRemoteTranslateSetting(string sourceLangCode, string targetLangCode) : base(CLASS_NAME, sourceLangCode, targetLangCode) { }

        public override bool Equals(object obj) => Call<bool>("equals", obj);

        public string SourceLangCode => Call<string>("getSourceLangCode");

        public string TargetLangCode => Call<string>("getTargetLangCode");

        public override int GetHashCode() => Call<int>("hashCode");

        public class Factory : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.mlsdk.translate.cloud.MLRemoteTranslateSetting$Factory";
            public Factory(AndroidJavaObject javaObject) : base(javaObject) { }

            public Factory() : base(CLASS_NAME) { }

            public MLRemoteTranslateSetting Create() => CallAsWrapper<MLRemoteTranslateSetting>("create");

            public Factory SetSourceLangCode(string sourceLangCode) => CallAsWrapper<Factory>("setSourceLangCode", sourceLangCode);

            public Factory SetTargetLangCode(string targetLangCode) => CallAsWrapper<Factory>("setTargetLangCode", targetLangCode);
        }
    }
}
