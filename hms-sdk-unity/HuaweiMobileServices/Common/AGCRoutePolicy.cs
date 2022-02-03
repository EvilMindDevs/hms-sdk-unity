using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Common
{
    public sealed class AGCRoutePolicy : JavaObjectWrapper
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.agconnect.AGCRoutePolicy");

        public static readonly AGCRoutePolicy UNKNOWN = sJavaClass.GetStaticAsWrapper<AGCRoutePolicy>("UNKNOWN");
        public static readonly AGCRoutePolicy CHINA = sJavaClass.GetStaticAsWrapper<AGCRoutePolicy>("CHINA");
        public static readonly AGCRoutePolicy GERMANY = sJavaClass.GetStaticAsWrapper<AGCRoutePolicy>("GERMANY");
        public static readonly AGCRoutePolicy RUSSIA = sJavaClass.GetStaticAsWrapper<AGCRoutePolicy>("RUSSIA");
        public static readonly AGCRoutePolicy SINGAPORE = sJavaClass.GetStaticAsWrapper<AGCRoutePolicy>("SINGAPORE");

        public int Route => getRouteValue(CallAsString("getRouteName"));

        public AGCRoutePolicy(AndroidJavaObject javaObject) : base(javaObject) { }

        private int getRouteValue(string route)
        {
            switch (route)
            {
                case "CN":
                    return 1;
                case "DE":
                    return 2;
                case "RU":
                    return 3;
                case "SG":
                    return 4;
                default:
                    return 0;
            }
        }
    }
}