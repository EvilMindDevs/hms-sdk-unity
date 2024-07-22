using HuaweiMobileServices.Utils;
using UnityEngine;


namespace HuaweiMobileServices.ML.LanguageDetection
{
    public class MLDetectedLang : JavaObjectWrapper
    {

        private const string CLASS_NAME = "com.huawei.hms.mlsdk.langdetect.MLDetectedLang";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);
        public MLDetectedLang(AndroidJavaObject androidJavaObject) : base(androidJavaObject) { }
        public MLDetectedLang(float probability, string langCode) : base(CLASS_NAME, probability, langCode) { }

        public bool Equals(AndroidJavaObject obj) => Call<bool>("equals", obj);
        public string GetLangCode() => Call<string>("getLangCode");
        public float GetProbability() => Call<float>("getProbability");
        public int HashCode() => Call<int>("hashCode");
        public string toString() => Call<string>("toString");


    }
}