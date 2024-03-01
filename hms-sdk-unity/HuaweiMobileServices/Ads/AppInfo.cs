using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Ads
{
    // https://developer.huawei.com/consumer/en/doc/HMSCore-References/appinfo-0000001600190342
    //https://developer.huawei.com/consumer/en/doc/HMSCore-References/nativead-0000001133473814#section16461225471
    // wrapper for com.huawei.hms.ads.AppInfo
    public class AppInfo : JavaObjectWrapper
    {
        public AppInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public string AppName => Call<string>("getAppName");

        public string AppDescription => Call<string>("getAppDesc");

        public string AppIconUrl => Call<string>("getAppIconUrl");

        public string AppDetailUrl => Call<string>("getAppDetailUrl");

        public string VersionName => Call<string>("getVersionName");

        public string DeveloperName => Call<string>("getDeveloperName");

        public string DownloadUrl => Call<string>("getDownloadUrl");

        public string SafeDownloadUrl => Call<string>("getSafeDownloadUrl");

        public string PrivacyPolicyLink => Call<string>("getPrivacyLink");

        public string PermissionUrl => Call<string>("getPermissionUrl");

        public void ShowPrivacyPolicy() => Call("showPrivacyPolicy", AndroidContext.ActivityContext);

        public void ShowPermissionPage() => Call("showPermissionPage", AndroidContext.ActivityContext);

    }
}
