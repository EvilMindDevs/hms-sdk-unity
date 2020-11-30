using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class Base64 : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]

        public Base64(AndroidJavaObject javaObject) : base(javaObject) { }

        [UnityEngine.Scripting.Preserve]
        public Base64() : base("com.huawei.cloud.base.util.Base64")
        {
        }
        public String EncodeBase64String(byte[] var0)
        {
            return Call<String>("encodeBase64String", var0);
        }

    }
}
