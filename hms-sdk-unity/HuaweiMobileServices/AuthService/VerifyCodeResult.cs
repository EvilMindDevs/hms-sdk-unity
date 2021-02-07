using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class VerifyCodeResult : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public VerifyCodeResult(AndroidJavaObject javaObject) : base(javaObject) { }
        public VerifyCodeResult(string paramString1, string paramString2) : base("com.huawei.agconnect.auth.VerifyCodeResult", paramString1, paramString2) { }

        public string ShortestInterval
        {
            get { return Call<string>("getShortestInterval"); }
        }

        public string ValidityPeriod
        {
            get { return Call<string>("getValidityPeriod"); }
        }

    }
}
