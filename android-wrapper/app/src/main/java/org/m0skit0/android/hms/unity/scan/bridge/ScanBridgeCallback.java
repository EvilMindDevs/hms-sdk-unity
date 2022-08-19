package org.m0skit0.android.hms.unity.scan.bridge;

import com.huawei.hms.ml.scan.HmsScan;

public interface ScanBridgeCallback {
    void onSuccess(final String scanText, final HmsScan hmsScan);
    void onFailure(final Exception exception);
}