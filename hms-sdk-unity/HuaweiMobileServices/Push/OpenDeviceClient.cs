using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Push
{
    public class OpenDeviceClient : JavaObjectWrapper
    {
        public OpenDeviceClient(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<OdidResult> Odid() => CallAsWrapper<TaskJavaObjectWrapper<OdidResult>>("getOdid");
    }
}
