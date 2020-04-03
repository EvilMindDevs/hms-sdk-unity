using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Base
{

    // Wrapper for com.huawei.hmf.tasks.Task
    public interface Task<T>
    {
        bool Complete { get; }

        bool Successful { get; }

        bool Canceled { get; }

        T Result { get; }

        Exception Exception { get; }

        Task<T> AddOnFailureListener(OnFailureListener onFailureListener);

        Task<T> AddOnSuccessListener(OnSuccessListener<T> onSuccessListener);
    }

    internal abstract class AbstractTask<T> : Task<T>
    {

        private AndroidJavaObject mJavaObject;

        internal AbstractTask(AndroidJavaObject javaObject)
        {
            mJavaObject = javaObject;
        }

        public bool Complete => mJavaObject.Call<bool>("isComplete");

        public bool Successful => mJavaObject.Call<bool>("isSuccessful");

        public bool Canceled => mJavaObject.Call<bool>("isCanceled");

        public T Result => mJavaObject.Call<T>("getResult");

        public Exception Exception => mJavaObject.Call<AndroidJavaObject>("getException").AsException();

        public Task<T> AddOnFailureListener(OnFailureListener onFailureListener)
        {
            var failureListenerWrapper = new OnFailureListenerWrapper(onFailureListener);
            mJavaObject = mJavaObject.Call<AndroidJavaObject>("addOnFailureListener", failureListenerWrapper);
            return this;
        }

        // Listener needs to be wrapped as well but since it involves wrapping the Java object received
        // it needs to be implemented by each task specifically.
        // Yeah, it's annoying but if you have a better solution, don't hesitate to implement it :)
        public abstract Task<T> AddOnSuccessListener(OnSuccessListener<T> onSuccessListener);
    }

}