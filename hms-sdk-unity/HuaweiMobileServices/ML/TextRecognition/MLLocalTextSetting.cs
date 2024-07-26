using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.ML.TextRecognition
{
    public class MLLocalTextSetting : JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.text.MLLocalTextSetting";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);
        public MLLocalTextSetting(AndroidJavaObject javaObject) : base(javaObject) { }

        public static int OCR_DETECT_MODE => sJavaClass.GetStaticFieldCached<int>(nameof(OCR_DETECT_MODE)); // 1
        public static int OCR_TRACKING_MODE => sJavaClass.GetStaticFieldCached<int>(nameof(OCR_TRACKING_MODE)); // 2

        public int OCRMode => Call<int>("getOCRMode");
        public string Language => Call<string>("getLanguage");
        public override int GetHashCode()
        {
            return Call<int>("hashCode");
        }
        public override bool Equals(object obj)
        {
            return Call<bool>("equals", obj);
        }

        public class Factory : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.mlsdk.text.MLLocalTextSetting$Factory";
            public Factory(AndroidJavaObject javaObject) : base(javaObject) { }
            public Factory() : base(CLASS_NAME) { }
            public MLLocalTextSetting Create() => CallAsWrapper<MLLocalTextSetting>("create");
            public Factory SetOCRMode(int mode) => CallAsWrapper<Factory>("setOCRMode", mode);
            public Factory SetLanguage(string language) => CallAsWrapper<Factory>("setLanguage", language);
        }
    }
}

