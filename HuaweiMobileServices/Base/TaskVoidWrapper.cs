using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Base
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class TaskVoidWrapper : TaskWrapper<Void>
    {
        public TaskVoidWrapper(AndroidJavaObject javaObject) : base(javaObject, (jObject) => Void.INSTANCE) { }
    }
}
