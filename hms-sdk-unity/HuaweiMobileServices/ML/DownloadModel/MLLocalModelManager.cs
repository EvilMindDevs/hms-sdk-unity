using HuaweiMobileServices.ML.Common;
using HuaweiMobileServices.Utils;
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

        // continue with the rest of the methods after adding remote model.
    }   
}
