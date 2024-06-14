using HuaweiMobileServices.ML.DownloadModel;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.ML.TextToSpeech
{
    public class MLTtsLocalModel: MLRemoteModel
    {
        //const string CLASS_NAME = "com.huawei.hms.mlsdk.tts.MLTtsLocalModel";
        public MLTtsLocalModel(AndroidJavaObject androidJavaObject) : base(androidJavaObject) { }
        public string GetSpeakerName() => Call<string>("getSpeakerName");

        public class Factory : JavaObjectWrapper
        {
            const string CLASS_NAME = "com.huawei.hms.mlsdk.tts.MLTtsLocalModel$Factory";
            public Factory(AndroidJavaObject androidJavaObject) : base(androidJavaObject) { }
            public Factory(string speakerName) : base(CLASS_NAME,speakerName) { }
            public MLTtsLocalModel Create() => CallAsWrapper<MLTtsLocalModel>("create");
        }
    }
}
