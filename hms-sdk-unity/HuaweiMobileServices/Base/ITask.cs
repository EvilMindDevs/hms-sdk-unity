using System;
using System.Threading.Tasks;

namespace HuaweiMobileServices.Base
{
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

        Task<T> Async();
    }

}