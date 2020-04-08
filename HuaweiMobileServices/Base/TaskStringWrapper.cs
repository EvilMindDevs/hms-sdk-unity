using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Base
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    internal class TaskStringWrapper : TaskWrapper<string>
    {
        public TaskStringWrapper(AndroidJavaObject javaObject) : base(javaObject, AndroidTypes.AsString) { }
    }
}
