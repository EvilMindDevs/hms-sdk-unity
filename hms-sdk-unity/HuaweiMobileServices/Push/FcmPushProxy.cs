using HuaweiMobileServices.Utils;
using System;

using UnityEngine;

namespace HuaweiMobileServices.Push
{ 
    public class FcmPushProxy
    {
        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.push.plugin.fcm.FcmPushProxy");
        public static bool Init() => androidJavaClass.Call<bool>("init", AndroidContext.ApplicationContext);
    }
}
