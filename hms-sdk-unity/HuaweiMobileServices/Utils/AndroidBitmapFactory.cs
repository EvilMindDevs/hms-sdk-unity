using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
namespace HuaweiMobileServices.Utils
{
    public class AndroidBitmapFactory : JavaObjectWrapper
    {
        private const string CLASS_NAME = "android.graphics.BitmapFactory";
        private static AndroidJavaClass BitmapFactoryClass = new AndroidJavaClass(CLASS_NAME);

        [UnityEngine.Scripting.Preserve]
        public AndroidBitmapFactory(AndroidJavaObject javaObject) : base(javaObject) { }
 
        public static AndroidJavaObject DecodeFile (string fileName) => BitmapFactoryClass.CallStatic<AndroidJavaObject>("decodeFile", fileName);


    }
}
