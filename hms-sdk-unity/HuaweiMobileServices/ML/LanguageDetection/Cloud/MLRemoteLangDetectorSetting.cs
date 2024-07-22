using HuaweiMobileServices.ML.LanguageDetection.Local;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.ML.LanguageDetection.Cloud
{
    public class MLRemoteLangDetectorSetting : JavaObjectWrapper
    {
        public MLRemoteLangDetectorSetting(AndroidJavaObject javaObject) : base(javaObject)
        {
        }

        public float GetTrustedThreshold() => Call<float>("getTrustedThreshold");

        public override bool Equals(object obj) => Call<bool>("equals", obj);

        public override int GetHashCode() => Call<int>("hashCode");

        public class Factory : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.mlsdk.langdetect.cloud.MLRemoteLangDetectorSetting$Factory";
            public Factory(AndroidJavaObject javaObject) : base(javaObject) { }
            public Factory() : base(CLASS_NAME) { }

            public MLRemoteLangDetectorSetting Create() => CallAsWrapper<MLRemoteLangDetectorSetting>("create");

            public Factory SetTrustedThreshold(float trustedThreshold) => CallAsWrapper<Factory>("setTrustedThreshold", trustedThreshold);

        }

    }
}

