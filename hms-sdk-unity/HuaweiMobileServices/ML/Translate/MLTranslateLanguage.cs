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
        const string CLASS_NAME = "com.huawei.hms.mlsdk.translate.MLTranslateLanguage";
        public MLTranslateLanguage(AndroidJavaObject androidJavaObject) : base(androidJavaObject) { }
        public MLTranslateLanguage() : base(CLASS_NAME) { }

        public ITask<ISet<string>> GetCloudAllLanguagesAsync()
        {
            var javaTask = Call<AndroidJavaObject>("getCloudAllLanguages");
            return new TaskWrapper<ISet<string>>(javaTask, AndroidJavaObjectExtensions.AsStringSet);
        }
        public ITask<ISet<string>> GetLocalAllLanguagesAsync()
        {
            var javaTask = Call<AndroidJavaObject>("getLocalAllLanguages");
            return new TaskWrapper<ISet<string>>(javaTask, AndroidJavaObjectExtensions.AsStringSet);
        }

        public ISet<string> GetCloudAllLanguages() => Call<AndroidJavaObject>("syncGetCloudAllLanguages").AsStringSet();

        public ISet<string> GetLocalAllLanguages() => Call<AndroidJavaObject>("syncGetLocalAllLanguages").AsStringSet();

    }
}
