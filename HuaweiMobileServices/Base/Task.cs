using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Base
{
    // Wrapper for com.huawei.hmf.tasks.Task
    public class Task<T>
    {

        private AndroidJavaObject mJavaObject;

        internal Task(AndroidJavaObject javaObject)
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