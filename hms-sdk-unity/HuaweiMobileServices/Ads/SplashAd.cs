using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Ads
{
    public class SplashAd : JavaObjectWrapper
    {
        public SplashAd(AndroidJavaObject javaObject) : base(javaObject) { }

        public SplashAd() : base("org.m0skit0.android.hms.unity.activity.SplashActivity") { }

        public string AdId { get; set; }

        public string Title { get; set; }

        public string SubText { get; set; }

        public Texture2D Icon { get; set; }

        public SplashAdOrientation Orientation { get; set; }

        public void LoadAd(AdParam adParam)
        {
            Call("setAdId", AdId);
            Call("setOrientation", (int)Orientation);
            Call("setTitleText", Title);
            Call("setSubText", SubText);
            Call("setImage", Icon.EncodeToPNG());
            Call("load", adParam);
        }

        public void SetSplashAdLoadListener(SplashAdLoadListener listener) => Call("setSplashAdLoadListener", listener);

        public void SetSplashAdDisplayListener(SplashAdDisplayListener listener) => Call("setSplashAdDisplayListener", listener);

        public enum SplashAdOrientation : int
        {
            LANDSCAPE = 0,
            PORTRAIT = 1
        }
    }
}
