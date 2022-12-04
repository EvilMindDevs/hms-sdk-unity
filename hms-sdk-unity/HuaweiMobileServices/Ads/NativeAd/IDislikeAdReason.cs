using UnityEngine;

namespace HuaweiMobileServices.Ads.NativeAd
{
    public class DislikeAdReason : AndroidJavaProxy
    {
        //wrapper for com.huawei.hms.ads.nativead.DislikeAdReason
        //https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/dislikeadreason-0000001050066851

        private readonly IDislikeAdReason IDislikeAdReason;

        public DislikeAdReason(IDislikeAdReason DislikeAdReason) : base("com.huawei.hms.ads.nativead.DislikeAdReason")
        {
            IDislikeAdReason = DislikeAdReason;
        }
        public string getDescription()
        {
            return IDislikeAdReason.getDescription();
        }
    }

    public interface IDislikeAdReason
    {
        string getDescription();
    }

}