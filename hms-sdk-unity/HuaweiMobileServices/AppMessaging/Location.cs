namespace HuaweiMobileServices
{
    using HuaweiMobileServices.Utils;
    using System;
    using System.Collections.Generic;
    using UnityEngine;

    public class Location : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public Location(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.agconnect.appmessaging.Location");
        public static Location BOTTOM => androidJavaClass.GetStaticAsWrapper<Location>("BOTTOM");
        public static Location CENTER => androidJavaClass.GetStaticAsWrapper<Location>("CENTER");
    }
}