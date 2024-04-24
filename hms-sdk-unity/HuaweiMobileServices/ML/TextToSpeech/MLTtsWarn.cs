using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.ML.TextToSpeech
{
    public class MLTtsWarn: JavaObjectWrapper
    {
        const string CLASS_NAME = "com.huawei.hms.mlsdk.tts.MLTtsWarn";
        public MLTtsWarn(AndroidJavaObject androidJavaObject) : base(androidJavaObject) { }

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public static int WARN_INSUFFICIENT_BANDWIDTH => sJavaClass.GetStatic<int>(nameof(WARN_INSUFFICIENT_BANDWIDTH));

        public int WarnId => Call<int>("getWarnId");

        public string WarnMessage => Call<string>("getWarnMsg");

        public JavaObject GetExtension() => CallAsWrapper<JavaObject>("getExtension");

        public override string ToString() => Call<string>("toString");

        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.mlsdk.tts.MLTtsWarn$Builder") { }

            public Builder SetWarnId(int param1Int) => CallAsWrapper<Builder>("setWarnId", param1Int);

            public Builder SetWarnMessage(string param1String) => CallAsWrapper<Builder>("setWarnMsg", param1String);

            public Builder SetExtension(JavaObject param1JavaObject) => CallAsWrapper<Builder>("setExtension", param1JavaObject);

            public MLTtsWarn Build() => CallAsWrapper<MLTtsWarn>("build");
        }
    }
}
