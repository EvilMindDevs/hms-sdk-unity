using System;

namespace HuaweiMobileServices.Base
{
    using UnityEngine;

    internal class TaskPrimitive<T> : AbstractTask<T>
    {

        [UnityEngine.Scripting.Preserve]
        public TaskPrimitive(AndroidJavaObject javaObject) : base(javaObject) { }

        public override T Result => Call<T>("getResult");

        public override ITask<T> AddOnSuccessListener(Action<T> onSuccessListener)
        {
            JavaObject = Call<AndroidJavaObject>("addOnSuccessListener", new OnSuccessListenerWrapper<T>(onSuccessListener));
            return this;
        }
    }
}
