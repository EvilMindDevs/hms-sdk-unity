namespace HuaweiMobileServices.Base
{
    using System;
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    internal class TaskJavaObjectWrapper<T> : TaskWrapper<T> where T : JavaObjectWrapper
    {
        internal TaskJavaObjectWrapper(AndroidJavaObject javaObject) : base(javaObject, AndroidTypes.AsWrapper<T>) { }
    }
}
