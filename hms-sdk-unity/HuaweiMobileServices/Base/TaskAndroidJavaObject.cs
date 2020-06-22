namespace HuaweiMobileServices.Base
{
    using UnityEngine;

    internal class TaskAndroidJavaObject : TaskWrapper<AndroidJavaObject>
    {
        [UnityEngine.Scripting.Preserve]
        public TaskAndroidJavaObject(AndroidJavaObject javaObject) : base(javaObject, (jObject) => jObject) { }
    }
}
