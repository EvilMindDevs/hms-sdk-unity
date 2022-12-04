using UnityEngine;

namespace HuaweiMobileServices.Ads.NativeAd
{
    public class DislikeAdListener : AndroidJavaProxy
    {
        //wrapper for com.huawei.hms.ads.nativead.DislikeAdListener
        //https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/dislikeadlistener-0000001050064902

        private readonly IDislikeAdListener IdislikeAdListener;

        public DislikeAdListener(IDislikeAdListener dislikeAdListener) : base("com.huawei.hms.ads.nativead.DislikeAdListener")
        {
            IdislikeAdListener = dislikeAdListener;
        }
        public void onAdDisliked()
        {
            IdislikeAdListener.onAdDisliked();
        }
    }

    public interface IDislikeAdListener
    {
        void onAdDisliked();
    }

}