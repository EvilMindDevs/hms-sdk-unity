using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Ads
{
    public class AdSize : JavaObjectWrapper
    {
        //wrapper for com.huawei.hms.ads.AdSize
        //https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/adsize-0000001050064882

        public AdSize(AndroidJavaObject javaObject) : base(javaObject) { }
        public AdSize(int width, int height) : base("com.huawei.hms.ads.AdSize", width, height) { }

        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ads.AdSize");

        public int Width
        {
            get => sJavaClass.Get<int>("getWidth");
        }

        public int Height
        {
            get => sJavaClass.Get<int>("getHeight");
        }
    }
}
