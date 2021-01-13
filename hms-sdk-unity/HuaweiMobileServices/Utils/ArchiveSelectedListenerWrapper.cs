using System;

namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    internal class ArchiveSelectedListenerWrapper : AndroidJavaProxy
    {

        private Action<AndroidIntent> mOnSuccessListener;
        private Action<HMSException> mOnFailureListener;

        public ArchiveSelectedListenerWrapper() : base("org.m0skit0.android.hms.unity.game.ArchiveSelectedListener") { }

        public ArchiveSelectedListenerWrapper AddOnSuccessListener(Action<AndroidIntent> onSuccessListener)
        {
            mOnSuccessListener = onSuccessListener;
            return this;
        }

        public ArchiveSelectedListenerWrapper AddOnFailureListener(Action<HMSException> onFailureListener)
        {
            mOnFailureListener = onFailureListener;
            return this;
        }

        // WARNING: DO NO MODIFY METHOD NAME, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onSuccess(AndroidJavaObject intent)
        {
            mOnSuccessListener?.Invoke(intent.AsWrapper<AndroidIntent>());
        }

        // WARNING: DO NO MODIFY METHOD NAME, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onFailure(AndroidJavaObject exception)
        {
            mOnFailureListener?.Invoke(exception.AsException());
        }
    }
}