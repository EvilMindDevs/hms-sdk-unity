using System;

namespace HuaweiMobileServices.Base
{
    // Wrapper for com.huawei.hmf.tasks.OnFailureListener
    public interface IOnFailureListener
    {
        void OnFailure(Exception exception);
    }

}