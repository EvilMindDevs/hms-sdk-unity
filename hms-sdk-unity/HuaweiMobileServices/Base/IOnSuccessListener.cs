using UnityEngine;

namespace HuaweiMobileServices.Base
{

    internal class OnSuccessListener<TResult> : AndroidJavaProxy
    {

        private readonly IOnSuccessListener<TResult> onSuccessListener;

        public OnSuccessListener(IOnSuccessListener<TResult> onSuccessListener) : base("com.huawei.hmf.tasks.OnSuccessListener")
        {
            this.onSuccessListener = onSuccessListener;
        }

        public void onSuccess(AndroidJavaObject result)
        {
            onSuccessListener.onSuccess(result);
        }
    }

    public interface IOnSuccessListener<TResult>
    {
        void onSuccess(AndroidJavaObject var1);
    }

}
