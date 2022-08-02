package org.m0skit0.android.hms.unity.ads.installreferrer.bridge;

public interface InstallReferrerStateCallbackListener {
    void onInstallReferrerSetupFinished(int responseCode);
    void onInstallReferrerServiceDisconnected();
}

