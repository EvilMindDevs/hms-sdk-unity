package org.m0skit0.android.hms.unity.ads.nativead;


import android.content.Context;
import android.util.Log;

import com.huawei.hms.ads.nativead.NativeAd;
import com.huawei.hms.ads.nativead.NativeView;

public class HmsNativeView {

    NativeView nativeView;

    public HmsNativeView(Context context) {
        nativeView = new NativeView(context);
    }

    public void setNativeAd(NativeAd nativeAd)
    {
        nativeView.setNativeAd(nativeAd);
    }

    public void performClick()
    {
        nativeView.performClick();
    }

    public void callOnClick()
    {
        nativeView.callOnClick();
    }

    public void gotoWhyThisAdPage()
    {
        nativeView.gotoWhyThisAdPage();
    }

}
