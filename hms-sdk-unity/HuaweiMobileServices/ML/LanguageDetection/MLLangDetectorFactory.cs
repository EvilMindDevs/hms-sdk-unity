using System;
using HuaweiMobileServices.Utils;
using UnityEngine;
using HuaweiMobileServices.ML.LanguageDetection.Local;
using HuaweiMobileServices.ML.Common;
using HuaweiMobileServices.ML.LanguageDetection.Cloud;

namespace HuaweiMobileServices.ML.LanguageDetection
{
    public class MLLangDetectorFactory: JavaObjectWrapper
    {
        const string CLASS_NAME = "com.huawei.hms.mlsdk.langdetect.MLLangDetectorFactory";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public MLLangDetectorFactory(AndroidJavaObject javaObject) : base(javaObject) { }

        public static MLLangDetectorFactory GetInstance() => sJavaClass.CallStaticAsWrapper<MLLangDetectorFactory>("getInstance");
        public static MLLangDetectorFactory GetInstance(MLApplication mLApplication) => sJavaClass.CallStaticAsWrapper<MLLangDetectorFactory>("getInstance", mLApplication);
        public MLLocalLangDetector GetLocalLangDetector() => CallAsWrapper<MLLocalLangDetector>("getLocalLangDetector");
        public MLLocalLangDetector GetLocalLangDetector(MLLocalLangDetectorSetting setting) => CallAsWrapper<MLLocalLangDetector>("getLocalLangDetector", setting);
        
        public MLRemoteLangDetector GetRemoteLangDetector() => CallAsWrapper<MLRemoteLangDetector>("getRemoteLangDetector");
        public MLRemoteLangDetector GetRemoteLangDetector(MLRemoteLangDetectorSetting setting) => CallAsWrapper<MLRemoteLangDetector>("getRemoteLangDetector", setting);

    }
}