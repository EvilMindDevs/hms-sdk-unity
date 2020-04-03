using System;

namespace HuaweiMobileServices.Base
{
    // Wrapper for com.huawei.hmf.tasks.OnFailureListener
    public interface OnFailureListener
    {
        void OnFailure(Exception exception);
    }

}