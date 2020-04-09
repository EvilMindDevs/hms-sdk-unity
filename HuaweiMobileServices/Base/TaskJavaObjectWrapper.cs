namespace HuaweiMobileServices.Base
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class TaskJavaObjectWrapper<T> : TaskWrapper<T> where T : JavaObjectWrapper
    {
        internal TaskJavaObjectWrapper(AndroidJavaObject javaObject) : base(javaObject, AndroidTypes.AsWrapper<T>) { }
    }
}
