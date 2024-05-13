using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.ML.Translate.Local
{
    public class MLLocalTranslatorModel : JavaObjectWrapper
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
