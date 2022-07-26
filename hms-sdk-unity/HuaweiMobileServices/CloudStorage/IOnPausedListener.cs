using UnityEngine;

namespace HuaweiMobileServices.CloudStorage
{

    public interface IOnPausedListener<TResult>
    {
        void OnPaused(TResult timePointState);
    }

    internal class OnPausedListener<TResult> : AndroidJavaProxy
    {

        private readonly IOnPausedListener<TResult> onPausedListener;

        public OnPausedListener(IOnPausedListener<TResult> OnPaused) : base("com.huawei.agconnect.cloud.storage.core.OnPausedListener")
        {
            onPausedListener = OnPaused;
        }

        public void OnPaused(TResult timePointState)
        {
            onPausedListener.OnPaused(timePointState);
        }
    }
}
