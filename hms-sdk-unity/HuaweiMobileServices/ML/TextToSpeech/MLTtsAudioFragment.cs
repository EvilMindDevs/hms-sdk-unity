using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.ML.TextToSpeech
{
    ///https://developer.huawei.com/consumer/en/doc/hiai-References/mlttsaudiofragment-0000001050738451
    public class MLTtsAudioFragment: JavaObjectWrapper
    {
        const string CLASS_NAME = "com.huawei.hms.mlsdk.tts.MLTtsAudioFragment";
        public MLTtsAudioFragment(AndroidJavaObject androidJavaObject) : base(androidJavaObject) { }
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public static int FORMAT_PCM_8BIT => sJavaClass.GetStatic<int>(nameof(FORMAT_PCM_8BIT));

        public static int FORMAT_PCM_16BIT => sJavaClass.GetStatic<int>(nameof(FORMAT_PCM_16BIT));

        public static int SAMPLE_RATE_16K => sJavaClass.GetStatic<int>(nameof(SAMPLE_RATE_16K));

        public static int CHANNEL_OUT_MONO => sJavaClass.GetStatic<int>(nameof(CHANNEL_OUT_MONO));

        public byte[] GetAudioData() => Call<byte[]>("getAudioData");

        public int GetAudioFormat() => Call<int>("getAudioFormat");

        public int GetSampleRateInHz() => Call<int>("getSampleRateInHz");

        public int GetChannelInfo() => Call<int>("getChannelInfo");

        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.mlsdk.tts.MLTtsAudioFragment$Builder") { }

            public Builder SetAudioData(byte[] param1ArrayOfByte) => CallAsWrapper<Builder>("setAudioData", param1ArrayOfByte);

            public Builder SetAudioFormat(int param1Int) => CallAsWrapper<Builder>("setAudioFormat", param1Int);

            public Builder SetSampleRateInHz(int param1Int) => CallAsWrapper<Builder>("setSampleRateInHz", param1Int);

            public Builder SetChannelInfo(int param1Int) => CallAsWrapper<Builder>("setChannelInfo", param1Int);

            public MLTtsAudioFragment Build() => CallAsWrapper<MLTtsAudioFragment>("build");
        }

    }
}
