package org.m0skit0.android.hms.unity.ads;


public class AdListenerWrapper extends com.huawei.hms.ads.AdListener {

    private final AdListener listener;

    public AdListenerWrapper(final AdListener listener) {
        super();
        this.listener = listener;
    }

    @Override
    public void onAdClosed() {
        super.onAdClosed();
        listener.onAdClosed();
    }

    @Override
    public void onAdFailed(int errorCode) {
        super.onAdFailed(errorCode);
        listener.onAdFailed(errorCode);
    }

    @Override
    public void onAdLeave() {
        super.onAdLeave();
        listener.onAdLeave();
    }

    @Override
    public void onAdOpened() {
        super.onAdOpened();
        listener.onAdOpened();
    }

    @Override
    public void onAdLoaded() {
        super.onAdLoaded();
        listener.onAdLoaded();
    }

    @Override
    public void onAdClicked() {
        super.onAdClicked();
        listener.onAdClicked();
    }

    @Override
    public void onAdImpression() {
        super.onAdImpression();
        listener.onAdImpression();
    }
}
