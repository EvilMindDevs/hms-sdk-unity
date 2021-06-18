namespace HuaweiMobileServices.Base
{
    using UnityEngine;

    internal class TaskAndroidJavaObject : TaskWrapper<AndroidJavaObject>
    {
        
        public TaskAndroidJavaObject(AndroidJavaObject javaObject) : base(javaObject, (jObject) => jObject) { }
    }
}
