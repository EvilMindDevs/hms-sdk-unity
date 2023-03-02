using UnityEngine;

namespace HuaweiMobileServices.Base
{

    internal class OnProgressListener<TResult> : AndroidJavaProxy
    {

        private readonly IOnProgressListener<TResult> onProgressListener;

        public OnProgressListener(IOnProgressListener<TResult> onProgressListener) : base("com.huawei.agconnect.cloud.storage.core.OnProgressListener")
        {
            this.onProgressListener = onProgressListener;
        }

        public void onProgress(AndroidJavaObject result)
        {
            onProgressListener.onProgress(result);
        }
    }

    public interface IOnProgressListener<TResult>
    {
        void onProgress(AndroidJavaObject var1);
    }

}
