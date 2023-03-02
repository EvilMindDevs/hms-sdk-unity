using UnityEngine;

namespace HuaweiMobileServices.Base
{
    
    internal class OnCanceledListener : AndroidJavaProxy
    {

        private readonly IOnCanceledListener onCanceledListener;

        public OnCanceledListener(IOnCanceledListener onCanceledListener) : base("com.huawei.hmf.tasks.OnCanceledListener")
        {
            this.onCanceledListener = onCanceledListener;
        }

        public void onCanceled()
        {
            onCanceledListener.onCanceled();
        }
    }

    public interface IOnCanceledListener
    {
        void onCanceled();
    }
    
}
