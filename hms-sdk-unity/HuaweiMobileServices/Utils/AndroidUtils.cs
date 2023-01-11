using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Utils
{
    /// <summary>
    /// The AndroidUtils class is a class written for easy access to android methods such as StartActivity.
    /// </summary>
    public class AndroidUtils
    {
        public static void LaunchAGHomePage()
        {
            AndroidIntent intent = new AndroidIntent("com.huawei.appmarket.intent.action.MainActivity");
            AndroidContext.StartActivity(intent);
        }

        public static void LaunchAppDetailPageAppID(string appID) 
        {
            AndroidIntent intent = new AndroidIntent("com.huawei.appmarket.appmarket.intent.action.AppDetail.withid");
            intent.SetPackage("com.huawei.appmarket");
            intent.PutExtra("appId", appID);
            AndroidContext.StartActivity(intent);
        }

        public static void LaunchAppDetailPagePackageName(string packageName)
        {
            AndroidIntent intent = new AndroidIntent("com.huawei.appmarket.intent.action.AppDetail");
            intent.SetPackage("com.huawei.appmarket");
            intent.PutExtra("APP_PACKAGENAME", packageName);
            AndroidContext.StartActivity(intent);
        }

        public static void StartActivity(AndroidIntent intent)
        {
            AndroidContext.StartActivity(intent);
        }

        public static void StartActivityForResult(AndroidIntent intent, int requestCode)
        {
            AndroidContext.StartActivityForResult(intent, requestCode);
        }

    }
}
