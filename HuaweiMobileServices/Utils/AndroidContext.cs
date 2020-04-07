using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    static class AndroidContext
    {

        private static AndroidJavaClass mUnityPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        private static AndroidJavaObject mApplicationContextJava = null;

        public static AndroidJavaObject GetActivityContext()
        {
            return mUnityPlayerClass.GetStatic<AndroidJavaObject>("currentActivity");
        }

        public static AndroidJavaObject GetApplicationContext()
        {
            if (mApplicationContextJava == null)
            {
                mApplicationContextJava = GetActivityContext().Call<AndroidJavaObject>("getApplicationContext");
            }
            return mApplicationContextJava;
        }
    }

}
