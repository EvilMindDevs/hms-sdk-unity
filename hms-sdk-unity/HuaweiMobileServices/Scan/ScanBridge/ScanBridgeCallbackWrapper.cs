namespace HuaweiMobileServices.Scan
{
    using HuaweiMobileServices.Utils;

    using System;

    using UnityEngine;

    internal class ScanBridgeCallbackWrapper : AndroidJavaProxy
    {
        private Action<String, HmsScan> mOnSuccessListener;
        private Action<HMSException> mOnFailureListener;

        public ScanBridgeCallbackWrapper() : base("org.m0skit0.android.hms.unity.scan.bridge.ScanBridgeCallback") { }
        public ScanBridgeCallbackWrapper AddOnSuccessListener(Action<String, HmsScan> onSuccessListener)
        {
            mOnSuccessListener = onSuccessListener;
            return this;
        }

        public ScanBridgeCallbackWrapper AddOnFailureListener(Action<HMSException> onFailureListener)
        {
            mOnFailureListener = onFailureListener;
            return this;
        }

        // WARNING: DO NO MODIFY METHOD NAME, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onSuccess(string scanText, AndroidJavaObject hmsScan)
        {
            this.CallOnMainThread(() => { mOnSuccessListener?.Invoke(scanText, hmsScan.AsWrapper<HmsScan>()); });
        }

        // WARNING: DO NO MODIFY METHOD NAME, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onFailure(AndroidJavaObject exception)
        {
            this.CallOnMainThread(() => { mOnFailureListener?.Invoke(exception.AsException()); });
        }
    }
}
