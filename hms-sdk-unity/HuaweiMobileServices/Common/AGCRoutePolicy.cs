using UnityEngine;

namespace HuaweiMobileServices.Common
{
    public sealed class AGCRoutePolicy 
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.agconnect.AGCRoutePolicy");

        public static readonly AGCRoutePolicy UNKNOWN = sJavaClass.GetStatic<AGCRoutePolicy>("UNKNOWN"); //or use new AGCRoutePolicy(0); for initiliaze
        public static readonly AGCRoutePolicy CHINA = sJavaClass.GetStatic<AGCRoutePolicy>("CHINA");
        public static readonly AGCRoutePolicy GERMANY = sJavaClass.GetStatic<AGCRoutePolicy>("GERMANY");
        public static readonly AGCRoutePolicy RUSSIA = sJavaClass.GetStatic<AGCRoutePolicy>("RUSSIA");
        public static readonly AGCRoutePolicy SINGAPORE = sJavaClass.GetStatic<AGCRoutePolicy>("SINGAPORE");

        private int route;
        private AGCRoutePolicy(int route)
        {
            this.route = route;
        }

        public string getRouteName()
        {
            switch (this.route)
            {
                case 1:
                    return "CN";
                case 2:
                    return "DE";
                case 3:
                    return "RU";
                case 4:
                    return "SG";
                default:
                    return "UNKNOWN";
            }
        }

        public bool equals(object var1)
        {
            if (this == var1)
            {
                return true;
            }
            else if (var1 != null && var1.GetType() == this.GetType())
            {
                AGCRoutePolicy var2 = (AGCRoutePolicy)var1;
                return route == var2.route;
            }
            else
            {
                return false;
            }
        }

        public int hashCode()
        {
            return new object[] { route }.GetHashCode();
        }
    }
}