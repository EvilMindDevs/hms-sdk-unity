using UnityEngine;

namespace HuaweiMobileServices.Base
{

    internal class OnCompleteListener<TResult> : AndroidJavaProxy
    {

        private readonly IOnCompleteListener<TResult> onCompleteListener;

        public OnCompleteListener(IOnCompleteListener<TResult> onCompleteListener) : base("com.huawei.hmf.tasks.OnCompleteListener")
        {
            this.onCompleteListener = onCompleteListener;
        }

        public void onComplete(AndroidJavaObject result)
        {
            onCompleteListener.onComplete(result);
        }
    }

    public interface IOnCompleteListener<TResult>
    {
        void onComplete(AndroidJavaObject var1);
    }

}
