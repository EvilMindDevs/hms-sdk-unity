using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Ads
{
    public class AdvertiserInfo : JavaObjectWrapper
    {
        //wrapper for com.huawei.hms.ads.AdvertiserInfo
        //https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/advertiserinfo-0000001420607914

        public AdvertiserInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        //private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ads.AdvertiserInfo");

        public int Sequence
        {
            get => Call<AndroidJavaObject>("getSeq").AsInt();
        }

        public string Key
        {
            get => Call<string>("getKey");
        }

        public string Value
        {
            get => Call<string>("getValue");
        }
    }
}
