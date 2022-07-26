using UnityEngine;

namespace HuaweiMobileServices.CloudStorage
{
    public interface IOnProgressListener<TResult>
    {
        void OnProgress(TResult timePointState);
    }

    internal class OnProgressListener<TResult> : AndroidJavaProxy
    {

        private readonly IOnProgressListener<TResult> onProgressListener;

        public OnProgressListener(IOnProgressListener<TResult> onProgress) : base("com.huawei.agconnect.cloud.storage.core.OnProgressListener")
        {
            onProgressListener = onProgress;
        }

        public void OnProgress(TResult timePointState)
        {
            onProgressListener.OnProgress(timePointState);
        }
    }

}
