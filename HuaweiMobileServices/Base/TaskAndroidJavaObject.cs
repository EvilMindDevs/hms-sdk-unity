namespace HuaweiMobileServices.Base
{
    using UnityEngine;

    internal class TaskAndroidJavaObject : TaskWrapper<AndroidJavaObject>
    {
        internal TaskAndroidJavaObject(AndroidJavaObject javaObject) : base(javaObject, (jObject) => jObject) { }
    }
}
