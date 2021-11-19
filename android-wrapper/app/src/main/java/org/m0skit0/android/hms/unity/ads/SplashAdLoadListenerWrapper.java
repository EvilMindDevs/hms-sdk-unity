package org.m0skit0.android.hms.unity.ads;

import com.huawei.hms.ads.splash.SplashView;

public class SplashAdLoadListenerWrapper extends SplashView.SplashAdLoadListener {
    private final SplashAdLoadListener listener;

    public SplashAdLoadListenerWrapper(final SplashAdLoadListener listener) {
        super();
        this.listener = listener;
    }

    @Override
    public void onAdDismissed() {
        super.onAdDismissed();
        listener.onAdDismissed();
    }

    @Override
    public void onAdFailedToLoad(int errorCode) {
        super.onAdFailedToLoad(errorCode);
        listener.onAdFailedToLoad(errorCode);
    }

    @Override
    public void onAdLoaded() {
        super.onAdLoaded();
        listener.onAdLoaded();
    }
}
