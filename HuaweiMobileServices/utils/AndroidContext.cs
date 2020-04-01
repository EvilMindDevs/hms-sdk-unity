using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    public class AndroidContext
    {

        private static AndroidJavaClass mUnityPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        private static AndroidJavaObject mApplicationContextJava = null;

        private AndroidContext()
        {
        }

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
