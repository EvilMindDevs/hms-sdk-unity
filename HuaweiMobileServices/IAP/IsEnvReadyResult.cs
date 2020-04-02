using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{
    public class IsEnvReadyResult
    {

        private readonly AndroidJavaObject mJavaObject;

        internal IsEnvReadyResult(AndroidJavaObject javaObject)
        {
            mJavaObject = javaObject;
        }

        public virtual int ReturnCode
        {
            get => mJavaObject.Call<int>("getReturnCode");
        }
    }
}
