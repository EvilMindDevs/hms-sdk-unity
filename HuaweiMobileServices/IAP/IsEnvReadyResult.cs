using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using HuaweiMobileServices.Base;

namespace HuaweiMobileServices.IAP
{
    public class IsEnvReadyResult : JavaObjectWrapperByConstructor
    {

        internal IsEnvReadyResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual int ReturnCode
        {
            get => mJavaObject.Call<int>("getReturnCode");
        }
    }
}
