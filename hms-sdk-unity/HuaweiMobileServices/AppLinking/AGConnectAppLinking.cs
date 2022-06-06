using HuaweiMobileServices.Utils;
using UnityEngine;
using static HuaweiMobileServices.AppLinking.ResolvedLinkData;

namespace HuaweiMobileServices.AppLinking
{
    public class AGConnectAppLinking
    {
        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.appLinking.AppLinking");

        public static IAGConnectAppLinking agc = null;

        public static IAGConnectAppLinking GetInstance()
        {
            if (agc == null)
            {
                agc = sJavaClass.CallStaticAsWrapper<AGConnectAppLinkingWrapper>("getInstance");
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
