using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Base
{
    internal class OnSuccessListenerWrapper<T> : AndroidJavaProxy where T : JavaObjectWrapper
    {
        protected IOnSuccessListener<T> mListener;

        public OnSuccessListenerWrapper(IOnSuccessListener<T> listener) : base("com.huawei.hmf.tasks.OnSuccessListener")
        {
            mListener = listener;
        }

        public void onSuccess(AndroidJavaObject result)
        {
            mListener.OnSuccess(result.AsWrapper<T>());
        }
    }
}
