namespace HuaweiMobileServices.Base
{
    using System;

    // Wrapper for com.huawei.hmf.tasks.OnFailureListener
    public interface IOnFailureListener
    {
        void OnFailure(Exception exception);
    }

}