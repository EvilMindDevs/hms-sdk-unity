namespace HuaweiMobileServices.Base
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class TaskStringWrapper : TaskWrapper<string>
    {
        [UnityEngine.Scripting.Preserve]
        public TaskStringWrapper(AndroidJavaObject javaObject) : base(javaObject, AndroidJavaObjectExtensions.AsString) { }
    }
}
