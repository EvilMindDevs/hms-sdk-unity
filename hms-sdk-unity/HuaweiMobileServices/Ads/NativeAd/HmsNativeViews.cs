using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Ads.NativeAd
{
    public class NativeView : JavaObjectWrapper
    {
        bool isNativeAdNull = true;

        public NativeView(AndroidJavaObject javaObject) : base(javaObject) { }

        //private static AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.ads.nativead.HmsNativeView");

        public NativeView() : base("org.m0skit0.android.hms.unity.ads.nativead.HmsNativeView", AndroidContext.ActivityContext) { }

        public void SetNativeAd(NativeAd nativeAd) {
            Call("setNativeAd", nativeAd.JavaObject);
            isNativeAdNull = false;
        }

        public void PerformClick() {
            if (!isNativeAdNull)
                Call("performClick");
            else
                Debug.LogError("[HMS] Cannot PerformClick. NativeAd is null. Call SetNativeAd method first.");
        }

        public void CallOnClick()
        {
            if (!isNativeAdNull)
                Call("callOnClick");
            else
                Debug.LogError("[HMS] Cannot callOnClick. NativeAd is null. Call SetNativeAd method first.");
        }

        public void GotoWhyThisAdPage()
        {
            if (!isNativeAdNull)
                Call("gotoWhyThisAdPage");
            else
                Debug.LogError("[HMS] Cannot gotoWhyThisAdPage. NativeAd is null. Call SetNativeAd method first.");
        }
    }
}
