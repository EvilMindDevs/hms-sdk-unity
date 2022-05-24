using System;
using System.Collections.Generic;
using System.Text;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.AppLinking
{
    public class AGConnectAppLinking : JavaObjectWrapper
    {
        public AGConnectAppLinking(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.agconnect.applinking.AGConnectAppLinking");

    }
}
