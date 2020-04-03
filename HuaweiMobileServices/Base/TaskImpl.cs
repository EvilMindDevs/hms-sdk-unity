using System;
using UnityEngine;
using HuaweiMobileServices.Utils;

namespace HuaweiMobileServices.Base
{

    internal class TaskImpl<T> : Task<T> where T : JavaObjectWrapperByConstructor
    {

        private AndroidJavaObject mJavaObject;

        internal TaskImpl(AndroidJavaObject javaObject)
        {
            mJavaObject = javaObject;
        }

        public bool Complete => mJavaObject.Call<bool>("isComplete");

        public bool Successful => mJavaObject.Call<bool>("isSuccessful");

        public bool Canceled => mJavaObject.Call<bool>("isCanceled");

        public T Result => mJavaObject.Call<AndroidJavaObject>("getResult").AsWrapper<T>();

        public Exception Exception => mJavaObject.Call<AndroidJavaObject>("getException").AsException();

        public Task<T> AddOnFailureListener(OnFailureListener onFailureListener)
        {
            var listenerWrapper = new OnFailureListenerWrapper(onFailureListener);
            mJavaObject = mJavaObject.Call<AndroidJavaObject>("addOnFailureListener", listenerWrapper);
            return this;
        }

        public Task<T> AddOnSuccessListener(OnSuccessListener<T> onSuccessListener)
        {
            var listenerWrapper = new OnSuccessListenerWrapper<T>(onSuccessListener);
            mJavaObject = mJavaObject.Call<AndroidJavaObject>("addOnFailureListener", listenerWrapper);
            return this;
        }
    }
}
