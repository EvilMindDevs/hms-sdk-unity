package org.m0skit0.android.hms.unity.ads;

public class ConsentUpdateListenerWrapper extends com.huawei.hms.ads.consent.inter.ConsentUpdateListener {

    private final ConsentUpdateListener listener;

    public ConsentUpdateListenerWrapper(final ConsentUpdateListener listener) {
        super();
        this.listener = listener;
    }

    @Override
    public void onFail(String desc) {
        super.onFail(desc);
        listener.onFail(desc);
    }

    @Override
    public void onSuccess(ConsentStatus consentStatus, boolean isNeedConsent, List<AdProvider> adProviders) {
        super.onSuccess(consentStatus, isNeedConsent, adProviders);
        listener.onSuccess(consentStatus, isNeedConsent, adProviders);
    }
}
