using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Base
{

    // Wrapper for com.huawei.hmf.tasks.Task
    public interface Task<T> where T : JavaObjectWrapperByConstructor
    {
        bool Complete { get; }

        bool Successful { get; }

        bool Canceled { get; }

        T Result { get; }

        Exception Exception { get; }

        Task<T> AddOnFailureListener(OnFailureListener onFailureListener);

        Task<T> AddOnSuccessListener(OnSuccessListener<T> onSuccessListener);
    }

}