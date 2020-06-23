namespace HuaweiMobileServices.Base
{
    using UnityEngine;

    internal class TaskAndroidJavaObject : TaskWrapper<AndroidJavaObject>
    {
        [UnityEngine.Scripting.Preserve]
        public static TaskAndroidJavaObject NewInstance(AndroidJavaObject javaObject) => new TaskAndroidJavaObject(javaObject);

        public TaskAndroidJavaObject(AndroidJavaObject javaObject) : base(javaObject, (jObject) => jObject) { }
    }
}
