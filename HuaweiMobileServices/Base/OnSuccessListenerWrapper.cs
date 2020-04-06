using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Base
{
    internal class OnSuccessListenerWrapper<T> : AndroidJavaProxy where T : JavaObjectWrapper
    {
        protected OnSuccessListener<T> mListener;

        public OnSuccessListenerWrapper(OnSuccessListener<T> listener) : base("com.huawei.hmf.tasks.OnSuccessListener")
        {
            mListener = listener;
        }

        public void onSuccess(AndroidJavaObject result)
        {
            mListener.OnSuccess(result.AsWrapper<T>());
        }
    }
}
