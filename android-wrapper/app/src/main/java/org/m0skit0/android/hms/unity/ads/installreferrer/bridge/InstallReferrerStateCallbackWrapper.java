package org.m0skit0.android.hms.unity.ads.installreferrer.bridge;

import android.util.Log;

import com.huawei.hms.ads.installreferrer.api.InstallReferrerStateListener;

public class InstallReferrerStateCallbackWrapper implements InstallReferrerStateListener {

    private final InstallReferrerStateCallbackListener listener;

    public InstallReferrerStateCallbackWrapper(InstallReferrerStateCallbackListener listener) {
        super();
        this.listener = listener;
    }

    @Override
    public void onInstallReferrerSetupFinished(int i) {
        listener.onInstallReferrerSetupFinished(i);
    }

    @Override
    public void onInstallReferrerServiceDisconnected() {
        listener.onInstallReferrerServiceDisconnected();
    }


}







