package org.m0skit0.android.hms.unity.ads;

public class SplashAdDisplayListenerWrapper extends com.huawei.hms.ads.splash.SplashAdDisplayListener {

    private final SplashAdDisplayListener listener;

    public SplashAdDisplayListenerWrapper(final SplashAdDisplayListener listener) {
        super();
        this.listener = listener;
    }

    @Override
    public void onAdClick() {
        super.onAdClick();
        listener.onAdClick();
    }

    @Override
    public void onAdShowed() {
        super.onAdShowed();
        listener.onAdShowed();
    }
}
