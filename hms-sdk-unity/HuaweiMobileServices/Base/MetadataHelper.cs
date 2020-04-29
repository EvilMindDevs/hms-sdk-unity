using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Base
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    public static class MetadataHelper
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.helper.MetadataHelper");

        public static string AppId => sJavaClass.CallStaticAsString("getAppId");
    }
}
