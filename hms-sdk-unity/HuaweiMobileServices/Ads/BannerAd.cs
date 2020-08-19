using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Ads
{
    public class BannerAd : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public BannerAd(AndroidJavaObject javaObject) : base(javaObject) { }
       
        public BannerAd(AdStatusListener mAdStatusListener) : base("org.m0skit0.android.hms.unity.ads.BannerAdProxy", AndroidContext.ActivityContext, mAdStatusListener) { }
         
        public string AdId
        {
            set;
            get;
        }

        public int positionType
        {
            set;
            get;
        }
        public String sizeType
        {
            set;
            get;
        }
        public AdStatusListener mAdStatusListener
        {
            set;
            get;
        }
        public void showBanner(AdParam adRequest) {
            handleRequestAd(adRequest);  
        }
        public void hideBanner()
        {
             handleHideAd();
        }
        public void destroyBanner( )
        {
            handleDestroyAd();
        }
        private void handleRequestAd(AdParam adRequest)
        {
            mAdStatusListener.mOnAdLoaded += onAdLoadSuccess;
            mAdStatusListener.mOnAdFailed += onAdLoadFail; 
             
            Call("setAdId", AdId);

            Call("setBannerAdPosition", positionType);
            
            Call("setAdSizeType", sizeType);

            Call("loadAd", adRequest);    
        }

        private void onAdLoadFail(object sender, AdLoadErrorCodeEventArgs args)
        {
            Debug.Log("[HMS] Bannerads onAdLoadFail" + args);
        }
        private void onAdLoadSuccess(object sender, EventArgs args)
        {
            Debug.Log("[HMS] Bannerads onAdLoadSuccess");
            Call("show");
        }

        private void handleHideAd()
        {
            if (this != null)
            {
                 Call("hide");
            }
        }

        private void handleDestroyAd()
        {
            if (this != null)
            {
                 Call("destroy");
            }
        }

    }
}
