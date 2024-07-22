using HuaweiMobileServices.Ads;
using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using UnityEngine;


namespace HuaweiMobileServices.ML.LanguageDetection.Local { 
public class MLLocalLangDetector : JavaObjectWrapper
    {
		public MLLocalLangDetector(AndroidJavaObject javaObject) : base(javaObject) { }

        private const string CLASS_NAME = "com.huawei.hms.mlsdk.langdetect.local.MLLocalLangDetector";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);
        public static float FIRST_BEST_DETECTION_LANGUAGE_TRUSTED_THRESHOLD => sJavaClass.GetStaticFieldCached<float>("FIRST_BEST_DETECTION_LANGUAGE_TRUSTED_THRESHOLD");
        public static float PROBABILITY_DETECTION_LANGUAGE_TRUSTED_THRESHOLD => sJavaClass.GetStaticFieldCached<float>("PROBABILITY_DETECTION_LANGUAGE_TRUSTED_THRESHOLD");
        public static string UNDETECTION_LANGUAGE_TRUSTED_THRESHOLD => sJavaClass.GetStaticFieldCached<string>("UNDETECTION_LANGUAGE_TRUSTED_THRESHOLD");

        public ITask<string> FirstBestDetect(string text) => CallAsWrapper<TaskPrimitive<string>>("firstBestDetect", text);
      
        public ITask<IList<MLDetectedLang>> ProbabilityDetect(string text)
        {
            var task = Call<AndroidJavaObject>("probabilityDetect", text);
            return new TaskWrapper<IList<MLDetectedLang>>(task, AndroidJavaObjectExtensions.AsListFromWrappable<MLDetectedLang>);
        }
        public IList<MLDetectedLang> SyncProbabilityDetect(string text) => CallAsWrapperList<MLDetectedLang>("syncProbabilityDetect",text); 
        public string SyncFirstBestDetect(string text) => Call<string>("syncFirstBestDetect", text);
        public void Stop() => Call("stop");
    }
}