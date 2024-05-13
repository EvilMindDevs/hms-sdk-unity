using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.ML.Translate.Local
{
    public class MLLocalTranslateSetting : JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.translate.local.MLLocalTranslateSetting";
        public MLLocalTranslateSetting(AndroidJavaObject javaObject) : base(javaObject) { }

        public string SourceLangCode => Call<string>("getSourceLangCode");

        public string TargetLangCode => Call<string>("getTargetLangCode");

        public override bool Equals(object obj) => Call<bool>("equals", obj);

        public override int GetHashCode() => Call<int>("hashCode");

        public class Factory: JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.mlsdk.translate.local.MLLocalTranslateSetting$Factory";
            public Factory(AndroidJavaObject javaObject) : base(javaObject) { }
            public Factory() : base(CLASS_NAME) { }

            public MLLocalTranslateSetting Create() => CallAsWrapper<MLLocalTranslateSetting>("create");

            public Factory SetSourceLangCode(string sourceLangCode) => CallAsWrapper<Factory>("setSourceLangCode", sourceLangCode);

            public Factory SetTargetLangCode(string targetLangCode) => CallAsWrapper<Factory>("setTargetLangCode", targetLangCode);
        }

    }
}
