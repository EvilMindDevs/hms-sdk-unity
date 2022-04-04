package org.m0skit0.android.hms.unity.ads;

public interface ConsentUpdateListener {
	
    void onSuccess(ConsentStatus consentStatus, boolean isNeedConsent, List<AdProvider> adProviders);
    void onFail(String desc);
}
