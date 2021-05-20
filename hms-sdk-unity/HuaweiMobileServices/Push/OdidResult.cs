using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Push
{
    public class OdidResult : JavaObjectWrapper
    {
        public OdidResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public bool Id => Call<bool>("getId");
    }
}
