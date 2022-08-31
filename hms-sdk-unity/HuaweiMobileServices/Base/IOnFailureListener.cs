using UnityEngine;

namespace HuaweiMobileServices.Base
{

    internal class OnFailureListener : AndroidJavaProxy 
    {

        private readonly IOnFailureListener onFailureListener;

        internal OnFailureListener(IOnFailureListener onFailureListener) : base("com.huawei.hmf.tasks.OnFailureListener")
        {
            this.onFailureListener = onFailureListener;
        }

        public void onFailure(AndroidJavaObject javaException)
        {
            onFailureListener.onFailure(javaException);
        }
    }

    public interface IOnFailureListener
    {
        void onFailure(AndroidJavaObject javaException);
    }

}
