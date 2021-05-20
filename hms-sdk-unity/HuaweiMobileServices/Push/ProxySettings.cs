using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Push
{
    public class ProxySettings 
    {
        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.push.plugin.base.proxy.ProxySettings");
        public static void SetCountryCode(String countryCode) => androidJavaClass.Call("setCountryCode",AndroidContext.ApplicationContext, countryCode);
    }
}
