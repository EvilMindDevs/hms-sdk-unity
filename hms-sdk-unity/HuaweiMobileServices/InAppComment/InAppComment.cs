using UnityEngine;

namespace HuaweiMobileServices.InAppComment
{
    public class InAppComment
    {
        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.inAppComment.InAppComment");

        public static void ShowInAppComment()
        {
            sJavaClass.CallStatic("showInAppComment");
        }

    }
}