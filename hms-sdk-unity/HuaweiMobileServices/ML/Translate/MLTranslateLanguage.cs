using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.ML.Translate
{
    // Wrapper for com.huawei.hms.mlsdk.translate.MLTranslateLanguage
    // https://developer.huawei.com/consumer/en/doc/hiai-References/mltranslatelanguage-0000001051136104
    public class MLTranslateLanguage: JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.translate.MLTranslateLanguage";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);
        public MLTranslateLanguage(AndroidJavaObject androidJavaObject) : base(androidJavaObject) { }
        public MLTranslateLanguage() : base(CLASS_NAME) { }

        public static ITask<ISet<string>> GetCloudAllLanguagesAsync()
        {
            var javaTask = sJavaClass.CallStatic<AndroidJavaObject>("getCloudAllLanguages");
            return new TaskWrapper<ISet<string>>(javaTask, AndroidJavaObjectExtensions.AsStringSet);
        }
        public static ITask<ISet<string>> GetLocalAllLanguagesAsync()
        {
            var javaTask = sJavaClass.CallStatic<AndroidJavaObject>("getLocalAllLanguages");
            return new TaskWrapper<ISet<string>>(javaTask, AndroidJavaObjectExtensions.AsStringSet);
        }

        public static ISet<string> GetCloudAllLanguages() => sJavaClass.CallStatic<AndroidJavaObject>("syncGetCloudAllLanguages").AsStringSet();

        public static ISet<string> GetLocalAllLanguages() => sJavaClass.CallStatic<AndroidJavaObject>("syncGetLocalAllLanguages").AsStringSet();

    }
}
