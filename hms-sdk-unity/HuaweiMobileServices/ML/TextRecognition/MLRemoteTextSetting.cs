using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.ML.TextRecognition
{
    public class MLRemoteTextSetting : JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.text.MLRemoteTextSetting";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);
        public MLRemoteTextSetting(AndroidJavaObject javaObject) : base(javaObject){}

        public static string ARC => sJavaClass.GetStaticFieldCached<string>(nameof(ARC)); // "ARC"
        public static string NGON => sJavaClass.GetStaticFieldCached<string>(nameof(NGON)); // "NGON"
        public static int OCR_COMPACT_SCENE => sJavaClass.GetStaticFieldCached<int>(nameof(OCR_COMPACT_SCENE)); // 2
        public static int OCR_LOOSE_SCENE => sJavaClass.GetStaticFieldCached<int>(nameof(OCR_LOOSE_SCENE)); // 1

        public string BorderType => Call<string>("getBorderType");
        public IList<string> LanguageList => CallAsStringList("getLanguageList");
        public int TextDensityScene => Call<int>("getTextDensityScene");

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
            private const string CLASS_NAME = "com.huawei.hms.mlsdk.text.MLRemoteTextSetting$Factory";
            public Factory(AndroidJavaObject javaObject) : base(javaObject) { }
            public Factory() : base(CLASS_NAME) { }
            public MLRemoteTextSetting Create() => CallAsWrapper<MLRemoteTextSetting>("create");
            public Factory SetBorderType(string borderType) => CallAsWrapper<Factory>("setBorderType", borderType);
            public Factory SetLanguageList(IList<string> languageList) => CallAsWrapper<Factory>("setLanguageList", languageList.AsJavaList());
            public Factory SetTextDensityScene(int textDensityScene) => CallAsWrapper<Factory>("setTextDensityScene", textDensityScene);
        }
    }
}
