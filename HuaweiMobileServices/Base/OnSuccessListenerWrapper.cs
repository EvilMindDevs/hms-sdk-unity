using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Base
{
    internal abstract class OnSuccessListenerWrapper<T> : AndroidJavaProxy
    {
        protected OnSuccessListener<T> mListener;

        public OnSuccessListenerWrapper(OnSuccessListener<T> listener) : base("com.huawei.hmf.tasks.OnSuccessListener")
        {
            mListener = listener;
        }

        public abstract void onSuccess(AndroidJavaObject result);
    }
}
