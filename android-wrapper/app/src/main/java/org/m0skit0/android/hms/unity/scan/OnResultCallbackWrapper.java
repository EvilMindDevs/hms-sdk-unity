package org.m0skit0.android.hms.unity.scan;

import com.huawei.hms.ml.scan.HmsScan;

public class OnResultCallbackWrapper implements com.huawei.hms.hmsscankit.OnResultCallback {

    private final OnResultCallback listener;

    public OnResultCallbackWrapper(final OnResultCallback listener) {
        super();
        this.listener = listener;
    }

    @Override
    public void onResult(HmsScan[] hmsScans) {
        listener.onResult(hmsScans);
    }
}
