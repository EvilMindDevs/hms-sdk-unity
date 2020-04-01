using UnityEngine;

namespace HuaweiMobileServices
{
    public class AndroidContext
    {

        private static AndroidJavaClass mUnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        private static AndroidJavaObject mApplicationContext = null;

        private AndroidContext()
        {
        }

        public static AndroidJavaObject getActivityContext()
        {
            return mUnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        }

        public static AndroidJavaObject getApplicationContext()
        {
            if (mApplicationContext == null)
            {
                mApplicationContext = getActivityContext().Call<AndroidJavaObject>("getApplicationContext");
            }
            return mApplicationContext;
        }
    }

}
