using UnityEngine;

namespace HuaweiMobileServices.Utils.ImageView
{
    public class ScaleType : JavaObjectWrapper
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("android.widget.ImageView.ScaleType");

        public static readonly ScaleType CENTER = sJavaClass.Get<ScaleType>("CENTER");
        public static readonly ScaleType CENTER_CROP = sJavaClass.Get<ScaleType>("CENTER_CROP");
        public static readonly ScaleType CENTER_INSIDE = sJavaClass.Get<ScaleType>("CENTER_INSIDE");
        public static readonly ScaleType FIT_CENTER = sJavaClass.Get<ScaleType>("FIT_CENTER");
        public static readonly ScaleType FIT_END = sJavaClass.Get<ScaleType>("FIT_END");
        public static readonly ScaleType FIT_START = sJavaClass.Get<ScaleType>("FIT_START");
        public static readonly ScaleType FIT_XY = sJavaClass.Get<ScaleType>("FIT_XY");
        public static readonly ScaleType MATRIX = sJavaClass.Get<ScaleType>("MATRIX");

        public int Route => getRouteValue(CallAsString("getRouteName"));

        public ScaleType(AndroidJavaObject javaObject) : base(javaObject) { }

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
