using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Base
{

    // Wrapper for com.huawei.hmf.tasks.Task
    public interface ITask<T> where T : JavaObjectWrapper
    {
        bool Complete { get; }

        bool Successful { get; }

        bool Canceled { get; }

        T Result { get; }

        Exception Exception { get; }

        ITask<T> AddOnFailureListener(IOnFailureListener onFailureListener);

        ITask<T> AddOnSuccessListener(IOnSuccessListener<T> onSuccessListener);
    }

}