using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using Void = HuaweiMobileServices.Utils.Void;
using UnityEngine;
using HuaweiMobileServices.ML.DownloadModel;

namespace HuaweiMobileServices.ML.Translate.Local
{
    public class MLLocalTranslator: JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.translate.local.MLLocalTranslator";

        public MLLocalTranslator(AndroidJavaObject javaObject) : base(javaObject) { }
        
        public int ModelLevel => Call<int>("getModelLevel");
        public ITask<string> TranslateAsync(string text) => CallAsWrapper<TaskPrimitive<string>>("asyncTranslate", text);
        public string Translate(string text) => Call<string>("syncTranslate", text);
        public ITask<Void> PraparedModel() => CallAsWrapper<TaskVoidWrapper>("preparedModel");
        public ITask<Void> PraparedModel(MLModelDownloadStrategy downloadStrategy) => CallAsWrapper<TaskVoidWrapper>("preparedModel", downloadStrategy);
        public ITask<Void> PraparedModel(MLModelDownloadStrategy downloadStrategy, MLModelDownloadListener listener) => CallAsWrapper<TaskVoidWrapper>("preparedModel", downloadStrategy, listener);
        public void Stop() => Call("stop");

    }
}
