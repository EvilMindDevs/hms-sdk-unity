package org.m0skit0.android.hms.unity.nearby;

import com.huawei.hms.nearby.discovery.ScanEndpointInfo;

public interface WifiShareListener {
    void onFound(String endpointId, ScanEndpointInfo info);
    void onLost(String endpointId);
    void onFetchAuthCode(String endpointId, String authCode);
    void onWifiShareResult(String endpointId, int statusCode);
}
