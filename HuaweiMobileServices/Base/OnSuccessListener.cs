using UnityEngine;

namespace HuaweiMobileServices.Base
{
    // Wrapper for com.huawei.hmf.tasks.OnSuccessListener
    public interface OnSuccessListener<T> where T : JavaObjectWrapperByConstructor
    {
        void OnSuccess(T result);
    }

}