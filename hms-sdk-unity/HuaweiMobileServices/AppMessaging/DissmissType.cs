using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.AppMessaging
{
    public class DismissType : JavaObjectWrapper
    {

        
        public DismissType(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.agconnect.appmessaging.AGConnectAppMessagingCallback$DismissType");
        public static DismissType BACK_BUTTON => androidJavaClass.GetStaticAsWrapper<DismissType>("BACK_BUTTON");
        public static DismissType CLICK => androidJavaClass.GetStaticAsWrapper<DismissType>("CLICK");
        public static DismissType CLICK_OUTSIDE => androidJavaClass.GetStaticAsWrapper<DismissType>("CLICK_OUTSIDE");
        public static DismissType AUTO => androidJavaClass.GetStaticAsWrapper<DismissType>("AUTO");
        public static DismissType UNKNOWN_DISMISS_TYPE => androidJavaClass.GetStaticAsWrapper<DismissType>("UNKNOWN_DISMISS_TYPE");
    }
}
