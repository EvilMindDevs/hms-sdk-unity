using System;
using UnityEngine;
using HuaweiMobileServices.Utils;

namespace HuaweiMobileServices.Base
{

    internal class TaskImpl<T> : JavaObjectWrapper, ITask<T> where T : JavaObjectWrapper
    {

        internal TaskImpl(AndroidJavaObject javaObject) : base(javaObject) { }

        public bool Complete => Call<bool>("isComplete");

        public bool Successful => Call<bool>("isSuccessful");

        public bool Canceled => Call<bool>("isCanceled");

        public T Result => Call<AndroidJavaObject>("getResult").AsWrapper<T>();

        public Exception Exception => Call<AndroidJavaObject>("getException").AsException();

        public ITask<T> AddOnFailureListener(IOnFailureListener onFailureListener)
        {
            var listenerWrapper = new OnFailureListenerWrapper(onFailureListener);
            mJavaObject = Call<AndroidJavaObject>("addOnFailureListener", listenerWrapper);
            return this;
        }

        public ITask<T> AddOnSuccessListener(IOnSuccessListener<T> onSuccessListener)
        {
            var listenerWrapper = new OnSuccessListenerWrapper<T>(onSuccessListener);
            mJavaObject = Call<AndroidJavaObject>("addOnFailureListener", listenerWrapper);
            return this;
        }
    }
}
