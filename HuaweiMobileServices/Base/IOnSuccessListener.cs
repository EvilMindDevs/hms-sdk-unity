using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Base
{
    // Wrapper for com.huawei.hmf.tasks.OnSuccessListener
    public interface IOnSuccessListener<T> where T : JavaObjectWrapper
    {
        void OnSuccess(T result);
    }

}