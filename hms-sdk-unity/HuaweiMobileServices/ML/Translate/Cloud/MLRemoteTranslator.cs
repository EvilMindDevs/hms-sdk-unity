using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.ML.Translate.Cloud
{
    // Wrapper for com.huawei.hms.mlsdk.translate.cloud.MLRemoteTranslator
    // https://developer.huawei.com/consumer/en/doc/hiai-References/mlremotetranslator-0000001050167532
    public class MLRemoteTranslator : JavaObjectWrapper
    {
        public MLRemoteTranslator(AndroidJavaObject javaObject) : base(javaObject) { }
      
        public ITask<string> TranslateAsync(string text) => CallAsWrapper<TaskPrimitive<string>>("asyncTranslate", text);

        public void Stop() => Call("stop");

        public string Translate(string text) => Call<string>("syncTranslate", text);
    }
}
