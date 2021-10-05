using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Analytics
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class HAUserProfileType : JavaObjectWrapper
    {
        public HAUserProfileType(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.analytics.type.HAUserProfileType");

        public static string USERLEVEL => androidJavaClass.GetStatic<string>("USERLEVEL");

        public static string ISFULLLEVEL => androidJavaClass.GetStatic<string>("ISFULLLEVEL");
    }
}
