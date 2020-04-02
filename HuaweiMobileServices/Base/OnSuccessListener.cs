using UnityEngine;

namespace HuaweiMobileServices.Base
{
    public abstract class OnSuccessListener<TResult> : AndroidJavaProxy
    {
        public OnSuccessListener() : base("com.huawei.hmf.tasks.OnSuccessListener") { }

        protected abstract void onSuccess(TResult paramTResult);
    }

}