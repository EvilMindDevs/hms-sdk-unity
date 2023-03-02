using UnityEngine;

namespace HuaweiMobileServices.Base
{

    internal class OnPausedListener<TResult> : AndroidJavaProxy
    {

        private readonly IOnPausedListener<TResult> onPausedListener;

        public OnPausedListener(IOnPausedListener<TResult> onPausedListener) : base("com.huawei.agconnect.cloud.storage.core.OnPausedListener")
        {
            this.onPausedListener = onPausedListener;
        }

        public void onPaused(AndroidJavaObject result)
        {
            onPausedListener.onPaused(result);
        }
    }

    public interface IOnPausedListener<TResult>
    {
        void onPaused(AndroidJavaObject var1);
    }

}
