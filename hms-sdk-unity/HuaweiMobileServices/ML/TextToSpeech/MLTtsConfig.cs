using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.ML.TextToSpeech
{
    //https://developer.huawei.com/consumer/en/doc/hiai-References/mlttsconfig-0000001050169551
    public class MLTtsConfig : JavaObjectWrapper
    {
        const string CLASS_NAME = "com.huawei.hms.mlsdk.tts.MLTtsConfig";
        public MLTtsConfig(AndroidJavaObject androidJavaObject) : base(androidJavaObject) { }
        public MLTtsConfig() : base(CLASS_NAME) { }

        public MLTtsConfig SetLanguage(string paramString) => CallAsWrapper<MLTtsConfig>("setLanguage", paramString);

        public MLTtsConfig SetPerson(string paramString) => CallAsWrapper<MLTtsConfig>("setPerson", paramString);

        public MLTtsConfig SetSpeed(float paramFloat) => CallAsWrapper<MLTtsConfig>("setSpeed", paramFloat);

        public MLTtsConfig SetVolume(float paramFloat) => CallAsWrapper<MLTtsConfig>("setVolume", paramFloat);

        public MLTtsConfig SetSynthesizeMode(int paramInt) => CallAsWrapper<MLTtsConfig>("setSynthesizeMode", paramInt);

        public MLTtsConfig Attach(MLTtsConfig paramInt) => CallAsWrapper<MLTtsConfig>("attach", paramInt);



        public string GetLanguage() => Call<string>("getLanguage");

        public string GetPerson() => Call<string>("getPerson");

        public float GetSpeed() => Call<float>("getSpeed");

        public float GetVolume() => Call<float>("getVolume");

        public int GetSynthesizeMode() => Call<int>("getSynthesizeMode");

        public override string ToString() => Call<string>("toString");



    }
}
