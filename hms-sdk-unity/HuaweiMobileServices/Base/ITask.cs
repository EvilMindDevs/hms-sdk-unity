namespace HuaweiMobileServices.Base
{
    using System;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hmf.tasks.Task
    public interface ITask<T>
    {
        bool Complete { get; }

        bool Successful { get; }

        bool Canceled { get; }

        T Result { get; }

        Exception Exception { get; }

        ITask<T> AddOnFailureListener(Action<HMSException> onFailureListener);

        ITask<T> AddOnSuccessListener(Action<T> onSuccessListener);
    }

}