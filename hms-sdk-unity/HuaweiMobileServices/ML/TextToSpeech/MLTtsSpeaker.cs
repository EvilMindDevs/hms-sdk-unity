using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.ML.TextToSpeech
{
    // https://developer.huawei.com/consumer/en/doc/hiai-References/mlttsspeaker-0000001051693148
    public class MLTtsSpeaker: JavaObjectWrapper
    {
        const string CLASS_NAME = "com.huawei.hms.mlsdk.tts.MLTtsSpeaker";

        public MLTtsSpeaker(AndroidJavaObject javaObject) : base(javaObject) { }
        public MLTtsSpeaker(string language, string name, string speakerDescription) : base(CLASS_NAME, language, name, speakerDescription) { }

        public MLTtsSpeaker(string language, string name, string modelSize, string speakerDescription) : base(CLASS_NAME, language, name, modelSize, speakerDescription) { }

        public string Language => Call<string>("getLanguage");

        public string Name => Call<string>("getName");

        public string ModelSize => Call<string>("getModelSize");

        public string SpeakerDescription => Call<string>("getSpeakerDescription");

        public override string ToString() => Call<string>("toString");

        public override bool Equals(object obj) => Call<bool>("equals", obj);

        public override int GetHashCode() => Call<int>("hashCode");

    }
}
