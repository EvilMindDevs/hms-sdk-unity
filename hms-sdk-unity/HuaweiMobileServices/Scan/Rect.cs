using HuaweiMobileServices.Utils;

using System.Collections;
using System.Collections.Generic;

using UnityEngine;


namespace HuaweiMobileServices
{
    public class Rect : JavaObjectWrapper
    {
        public Rect(AndroidJavaObject javaObject) : base(javaObject) { }
        public Rect() : base("android.graphics.Rect") { }

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("android.graphics.Rect");




    }
}