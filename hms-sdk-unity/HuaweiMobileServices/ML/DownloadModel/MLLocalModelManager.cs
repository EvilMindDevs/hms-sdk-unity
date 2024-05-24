using HuaweiMobileServices.Base;
using HuaweiMobileServices.ML.Common;
using HuaweiMobileServices.Utils;
using HuaweiMobileServices.Utils.java.io;
using UnityEngine;

namespace HuaweiMobileServices.ML.DownloadModel
{
    // Wrapper for com.huawei.hms.mlsdk.model.download.MLLocalModelManager
    // https://developer.huawei.com/consumer/en/doc/hiai-References/mllocalmodelmanager-0000001050328834
    public class MLLocalModelManager : JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.model.download.MLLocalModelManager";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public MLLocalModelManager(AndroidJavaObject javaObject) : base(javaObject) { }

        public static MLLocalModelManager Instance => sJavaClass.CallStaticAsWrapper<MLLocalModelManager>("getInstance");

        public static MLLocalModelManager GetInstance(MLApplication application) => sJavaClass.CallStaticAsWrapper<MLLocalModelManager>("getInstance", application);

        public ITask<Void> DeleteModel(MLRemoteModel model) => CallAsWrapper<TaskVoidWrapper>("deleteModel", model);

        public ITask<Void> DownloadModel(MLRemoteModel model) => CallAsWrapper<TaskVoidWrapper>("downloadModel", model);

        public ITask<Void> DownloadModel(MLRemoteModel model, MLModelDownloadStrategy strategy) => CallAsWrapper<TaskVoidWrapper>("downloadModel", model, strategy);

        public ITask<Void> DownloadModel(MLRemoteModel model, MLModelDownloadStrategy strategy, MLModelDownloadListener listener) => CallAsWrapper<TaskVoidWrapper>("downloadModel", model, strategy, listener);

        public ITask<File> GetRecentModelFile(MLRemoteModel model) => CallAsWrapper<TaskJavaObjectWrapper<File>>("getRecentModelFile", model);

        public ITask<bool> IsModelExist(MLRemoteModel model) => CallAsWrapper<TaskPrimitive<bool>>("isModelExist", model);
    }
}
