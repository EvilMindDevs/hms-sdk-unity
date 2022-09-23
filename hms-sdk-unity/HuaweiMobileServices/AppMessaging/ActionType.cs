
using HuaweiMobileServices.Utils;

using UnityEngine;

namespace HuaweiMobileServices.AppMessaging
{
    public class ActionType : JavaObjectWrapper
    {
        public ActionType(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.agconnect.appmessaging.ActionType");

        public static int REDIRECT => androidJavaClass.Call<int>("REDIRECT");
        public static int SHARE => androidJavaClass.Call<int>("SHARE");
    }
}