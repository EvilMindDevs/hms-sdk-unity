using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.InAppComment
{
    /// <summary>
    /// The in-app comments service allows you to prompt your users to submit ratings and make comments for your app.
    /// </summary>
    public class InAppComment
    {
        // private static AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.inAppComment.InAppComment");

        /// <summary>
        /// When this method is triggered, the In-App comment window opens if the appropriate conditions are met.
        /// </summary>
        /// <para>
        /// We recommend that the screen orientation should support portrait for better results with In-App Comment. Testing the Function: https://developer.huawei.com/consumer/en/doc/development/AppGallery-connect-Guides/agc-comments-develop-0000001062858332#section2965155114202
        /// </para>
        public static void ShowInAppComment()
        {
            AndroidIntent intent = new AndroidIntent("com.huawei.appmarket.intent.action.guidecomment");
            intent.SetPackage("com.huawei.appmarket");
            AndroidContext.ActivityContext.Call("startActivityForResult", intent.Intent, 1001);
        }
    }
}