using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Ads
{
    public class BannerAd : JavaObjectWrapper
    {
        public BannerAd(AndroidJavaObject javaObject) : base(javaObject) { }

        public BannerAd(AdStatusListener AdStatusListener) : base("org.m0skit0.android.hms.unity.ads.BannerAd", AndroidContext.ActivityContext, AdStatusListener) { }

        public string AdId { get; set; }

        public int PositionType { get; set; }

        public String SizeType { get; set; }

        public AdStatusListener AdStatusListener { get; set; }

        public long BannerRefresh { get; set; }

        public void LoadBanner(AdParam adRequest)
        {
            Call("setAdId", AdId);

            Call("setBannerAdPosition", PositionType);

            Call("setAdSizeType", SizeType);

            if (BannerRefresh != 0)
                Call("setBannerRefresh", Math.Max(Math.Min(BannerRefresh, 120), 30));

            Call("loadAd", adRequest);
        }

        public void HideBanner()
        {
            if (this != null)
            {
                Call("hide");
            }
        }

        public void DestroyBanner()
        {
            if (this != null)
            {
                Call("destroy");
            }
        }

        public void ShowBanner()
        {
            Call("show");
        }

        public void SetBannerRefresh(long value)
        {
            Call("setBannerRefresh", Math.Max(Math.Min(value, 120), 30));
        }
    }
}
