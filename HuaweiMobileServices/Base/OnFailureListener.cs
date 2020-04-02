using System;
using UnityEngine;

namespace HuaweiMobileServices.Base
{
    public abstract class OnFailureListener : AndroidJavaProxy
    {
        public OnFailureListener() : base("com.huawei.hmf.tasks.OnFailureListener") { }

        protected abstract void onFailure(Exception paramException);
    }

}