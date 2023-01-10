using UnityEngine;

namespace HuaweiMobileServices.InAppComment
{
    /// <summary>
    /// The in-app comments service allows you to prompt your users to submit ratings and make comments for your app.
    /// </summary>
    public class InAppComment
    {
        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.inAppComment.InAppComment");

        /// <summary>
        /// When this method is triggered, the In-App comment window opens if the appropriate conditions are met.
        /// </summary>
        /// <para>
        /// For In-App Comment to work, screen orientation must support portrait. Testing the Function: https://developer.huawei.com/consumer/en/doc/development/AppGallery-connect-Guides/agc-comments-develop-0000001062858332#section2965155114202
        /// </para>
        public static void ShowInAppComment()
        {
            if (Screen.orientation == ScreenOrientation.AutoRotation || Screen.orientation == ScreenOrientation.Portrait || Screen.orientation == ScreenOrientation.PortraitUpsideDown)
            {
                sJavaClass.CallStatic("showInAppComment");
            }
            else
            {
                Debug.LogError("[HMS] InAppComment ShowInAppComment: Screen.orientation is not valid. For In-App Comment to work, screen orientation must support portrait. Screen.orientation is " + Screen.orientation);
            }
        }
    }
}