package org.m0skit0.android.hms.unity.ads;

public interface AdListener {
    void onAdClosed();
    void onAdFailed(int errorCode);
    void onAdLeave();
    void onAdOpened();
    void onAdLoaded();
    void onAdClicked();
    void onAdImpression();
}
