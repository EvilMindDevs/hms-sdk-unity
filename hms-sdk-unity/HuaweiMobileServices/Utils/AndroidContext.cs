﻿namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    internal static class AndroidContext
    {

        private static AndroidJavaClass mUnityPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        private static AndroidJavaObject mApplicationContextJava = null;

        public static AndroidJavaObject ActivityContext => mUnityPlayerClass.GetStatic<AndroidJavaObject>("currentActivity");

        public static AndroidJavaObject ApplicationContext
        {
            get
            {
                if (mApplicationContextJava == null)
                {
                    mApplicationContextJava = ActivityContext.Call<AndroidJavaObject>("getApplicationContext");
                }
                return mApplicationContextJava;
            }
        }

        public static void StartActivity(AndroidIntent intent) => ActivityContext.Call("startActivity", intent.Intent);

        public static void StartActivityForResult(AndroidIntent intent, int requestCode) => ActivityContext.Call("startActivityForResult", intent.Intent, requestCode);

    }

}
