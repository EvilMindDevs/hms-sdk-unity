using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Base
{
    internal class OnFailureListenerWrapper : AndroidJavaProxy
    {

        private readonly OnFailureListener mListener;

        internal OnFailureListenerWrapper(OnFailureListener listener) : base("com.huawei.hmf.tasks.OnFailureListener")
        {
            mListener = listener;
        }

        public void onFailure(AndroidJavaObject javaException)
        {
            mListener.OnFailure(javaException.AsException());
        }
    }
}
