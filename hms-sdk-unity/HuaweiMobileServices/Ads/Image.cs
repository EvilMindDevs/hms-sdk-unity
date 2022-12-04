using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Ads
{
    public class Image : JavaObjectWrapper
    {
        //wrapper for com.huawei.hms.ads.Image
        //https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/image-0000001050064886

        public Image(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ads.Image");

        /*public Drawable Drawable
        {
            get => CallAsWrapper<Drawable>("getDrawable");
        }*/

        public Uri Uri
        {
            get => CallAsWrapper<Uri>("getUri");
        }

        public double Scale
        {
            get => sJavaClass.Get<double>("getScale");
        }

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