namespace HuaweiMobileServices.Base
{
    using HuaweiMobileServices.Utils;
    using System;
    using UnityEngine;

    // Wrapper for com.huawei.hmf.tasks.Task
    public interface ITask<T>
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