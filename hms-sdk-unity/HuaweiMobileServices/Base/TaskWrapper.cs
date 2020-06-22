namespace HuaweiMobileServices.Base
{
    using System;
    using UnityEngine;

    // Note: this class cannot be called with AsWrapper() since constructor has 2 parameters
    internal class TaskWrapper<T> : AbstractTask<T>
    {

        private readonly Func<AndroidJavaObject, T> mConverter;

        [UnityEngine.Scripting.Preserve]
        internal TaskWrapper(AndroidJavaObject javaObject, Func<AndroidJavaObject, T> func) : base(javaObject)
        {
            mConverter = func;
        }

        override public T Result
        {
            get
            {
                var result = Call<AndroidJavaObject>("getResult");
                return mConverter.Invoke(result);
            }
        }

        override public ITask<T> AddOnSuccessListener(Action<T> onSuccessListener)
        {
            var listenerWrapper = new OnSuccessListenerConverterWrapper<T>(onSuccessListener, mConverter);
            JavaObject = Call<AndroidJavaObject>("addOnSuccessListener", listenerWrapper);
            return this;
        }
    }
}
