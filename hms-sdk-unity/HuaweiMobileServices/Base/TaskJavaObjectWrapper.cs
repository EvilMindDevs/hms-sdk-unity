namespace HuaweiMobileServices.Base
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class TaskJavaObjectWrapper<T> : TaskWrapper<T> where T : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public static TaskJavaObjectWrapper<T> NewInstance(AndroidJavaObject javaObject) => new TaskJavaObjectWrapper<T>(javaObject);

        public TaskJavaObjectWrapper(AndroidJavaObject javaObject) : base(javaObject, AndroidJavaObjectExtensions.AsWrapper<T>) { }
    }
}
