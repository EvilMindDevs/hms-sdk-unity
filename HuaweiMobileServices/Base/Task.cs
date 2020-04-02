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

    public class TaskImpl<T> : Task<T>
    {

        private AndroidJavaObject mJavaObject;

        internal TaskImpl(AndroidJavaObject javaObject)
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
            mJavaObject = mJavaObject.Call<AndroidJavaObject>("addOnFailureListener", onFailureListener);
            return this;
        }

        public Task<T> AddOnSuccessListener(OnSuccessListener<T> onSuccessListener)
        {
            mJavaObject = mJavaObject.Call<AndroidJavaObject>("addOnSuccessListener", onSuccessListener);
            return this;
        }
    }

}