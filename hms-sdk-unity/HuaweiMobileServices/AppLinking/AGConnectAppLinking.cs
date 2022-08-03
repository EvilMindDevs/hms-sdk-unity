using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;
using static HuaweiMobileServices.AppLinking.ResolvedLinkData;


namespace HuaweiMobileServices.AppLinking
{
    public class AGConnectAppLinking : JavaObjectWrapper
    {
        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.appLinking.AppLinking");

        public AGConnectAppLinking(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<ResolvedLinkData> GetAppLinking() => CallAsWrapper<TaskJavaObjectWrapper<ResolvedLinkData>>("getAppLinking", AndroidContext.ActivityContext);

        public static AGConnectAppLinking agc = null;

        public static AGConnectAppLinking GetInstance()
        {
            if (agc == null)
            {
                agc = sJavaClass.CallStaticAsWrapper<AGConnectAppLinking>("getInstance");
            }
            return agc;
        }

        public static void ShareLink(string agcLink)
        {
            sJavaClass.CallStatic("shareLink", agcLink);
        }

        public static LinkType GetLinkType(ResolvedLinkData resolvedLinkData)
        {
            int linkType = sJavaClass.CallStatic<int>("getLinkType", resolvedLinkData.JavaObject);

            if (linkType == 0) return LinkType.AppLinking;
            else return LinkType.UnifiedLinking;
        }


    }
}
