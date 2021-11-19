package org.m0skit0.android.hms.unity.ads;

public interface SplashAdLoadListener {
    void onAdDismissed();

    void onAdFailedToLoad(final int errorCode);

    void onAdLoaded();
}
