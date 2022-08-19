package org.m0skit0.android.hms.unity.scan;

import com.huawei.hms.ml.scan.HmsScan;

public interface OnResultCallback {
    void onResult(HmsScan[] result);
}
