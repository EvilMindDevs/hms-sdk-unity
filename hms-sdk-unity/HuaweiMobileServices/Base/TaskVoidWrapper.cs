namespace HuaweiMobileServices.Base
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class TaskVoidWrapper : TaskWrapper<Void>
    {
        [UnityEngine.Scripting.Preserve]
        public static TaskVoidWrapper NewInstance(AndroidJavaObject javaObject) => new TaskVoidWrapper(javaObject);

        public TaskVoidWrapper(AndroidJavaObject javaObject) : base(javaObject, (jObject) => Void.INSTANCE) { }
    }
}
