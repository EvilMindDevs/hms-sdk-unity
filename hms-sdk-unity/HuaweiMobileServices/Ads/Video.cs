using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Ads
{
    public class Video : JavaObjectWrapper
    {
        //wrapper for com.huawei.hms.ads.Video
        //https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/video-0000001194699274

        public Video(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ads.Video");

        public Uri Uri
        {
            get => CallAsWrapper<Uri>("getUri");
        }

        public float AspectRatio
        {
            get => sJavaClass.Get<float>("getAspectRatio");
        }

        public int Duration
        {
            get => sJavaClass.Get<int>("getDuration");
        }

    }
}