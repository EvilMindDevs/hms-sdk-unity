namespace HuaweiMobileServices.Base
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class TaskStringWrapper : TaskWrapper<string>
    {
        [UnityEngine.Scripting.Preserve]
        public static TaskStringWrapper NewInstance(AndroidJavaObject javaObject) => new TaskStringWrapper(javaObject);

        public TaskStringWrapper(AndroidJavaObject javaObject) : base(javaObject, AndroidJavaObjectExtensions.AsString) { }
    }
}
