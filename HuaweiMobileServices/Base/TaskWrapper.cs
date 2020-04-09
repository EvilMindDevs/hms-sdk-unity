namespace HuaweiMobileServices.Base
{
    using HuaweiMobileServices.Utils;
    using System;
    using UnityEngine;

    internal class TaskWrapper<T> : JavaObjectWrapper, ITask<T>
    {

        private readonly Func<AndroidJavaObject, T> mConverter;

        internal TaskWrapper(AndroidJavaObject javaObject, Func<AndroidJavaObject, T> func) : base(javaObject)
        {
            mConverter = func;
        }

        public bool Complete => Call<bool>("isComplete");

        public bool Successful => Call<bool>("isSuccessful");

        public bool Canceled => Call<bool>("isCanceled");

        public virtual T Result
        {
            get
            {
                var result = Call<AndroidJavaObject>("getResult");
                return mConverter.Invoke(result);
            }
        }

        public Exception Exception => Call<AndroidJavaObject>("getException").AsException();

        public ITask<T> AddOnFailureListener(Action<Exception> onFailureListener)
        {
            var listenerWrapper = new OnFailureListenerWrapper(onFailureListener);
            JavaObject = Call<AndroidJavaObject>("addOnFailureListener", listenerWrapper);
            return this;
        }

        public ITask<T> AddOnSuccessListener(Action<T> onSuccessListener)
        {
            var listenerWrapper = new OnSuccessListenerWrapper<T>(onSuccessListener, mConverter);
            JavaObject = Call<AndroidJavaObject>("addOnFailureListener", listenerWrapper);
            return this;
        }
    }
}
