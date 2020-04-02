using UnityEngine;

namespace HuaweiMobileServices.Base
{
    // Wrapper for com.huawei.hmf.tasks.OnSuccessListener
    public abstract class OnSuccessListener<T> : AndroidJavaProxy
    {
        public OnSuccessListener() : base("com.huawei.hmf.tasks.OnSuccessListener") { }

        protected abstract void onSuccess(T result);
    }

}