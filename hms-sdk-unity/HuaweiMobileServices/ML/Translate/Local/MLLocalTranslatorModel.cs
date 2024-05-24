using HuaweiMobileServices.ML.DownloadModel;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.ML.Translate.Local
{
    // Wrapper for com.huawei.hms.mlsdk.translate.local.MLLocalTranslatorModel
    // https://developer.huawei.com/consumer/en/doc/hiai-References/mllocaltranslatormodel-0000001050444213
    public class MLLocalTranslatorModel : MLRemoteModel
    {
        public const string CLASS_NAME = "com.huawei.hms.mlsdk.translate.local.MLLocalTranslatorModel";

        public MLLocalTranslatorModel(AndroidJavaObject javaObject) : base(javaObject) { }

        public string LanguageCode => Call<string>("getLanguageCode");
        public override int GetHashCode() => Call<int>("hashCode");
        public override bool Equals(object obj) => Call<bool>("equals", obj);

        public class Factory : JavaObjectWrapper
        {
            public const string CLASS_NAME = "com.huawei.hms.mlsdk.translate.local.MLLocalTranslatorModel$Factory";

            public Factory(AndroidJavaObject javaObject) : base(javaObject) { }

            public Factory(string languageCode) : base(CLASS_NAME, languageCode) { }

            public MLLocalTranslatorModel Create() => CallAsWrapper<MLLocalTranslatorModel>("create");
        }
    }
}
