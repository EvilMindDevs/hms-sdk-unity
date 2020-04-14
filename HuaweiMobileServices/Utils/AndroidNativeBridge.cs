using System;

namespace HuaweiMobileServices.Utils
{
    using UnityEngine;
    using HuaweiMobileServices.Base;

    internal class AndroidNativeBridge<T>
    {

        private static readonly AndroidJavaClass NATIVE_BRIDGE_ACTIVITY = new AndroidJavaClass("com.pues.lo.que.sea.NativeBridgeActivity");

        private const string STATUS_NAME = "status";

        private AndroidIntent mIntent = new AndroidIntent(NATIVE_BRIDGE_ACTIVITY);

        private Action<Exception> mFailureAction;
        private Action<T> mSuccessAction;

        public AndroidNativeBridge<T> AddOnFailureListener(Action<Exception> onFailureListener)
        {
            mFailureAction = onFailureListener;
            return this;
        }

        public AndroidNativeBridge<T> AddOnSuccessListener(Action<T> onSuccessListener)
        {
            mSuccessAction = onSuccessListener;
            return this;
        }

        public AndroidNativeBridge<T> AddJavaObject(string name, AndroidJavaObject javaObject)
        {
            mIntent.PutExtra(name, javaObject);
            return this;
        }

        public void Execute()
        {
            AndroidContext.GetActivityContext().Call("startActivity", mIntent);
        }
    }
}
