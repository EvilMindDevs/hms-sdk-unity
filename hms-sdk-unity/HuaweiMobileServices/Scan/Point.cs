using HuaweiMobileServices.Utils;

using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace HuaweiMobileServices.Scan
{
    public class Point : JavaObjectWrapper
    {
        public Point(AndroidJavaObject javaObject) : base(javaObject) { }
        public Point() : base("android.graphics.Point") { }

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("android.graphics.Point");


    }

}