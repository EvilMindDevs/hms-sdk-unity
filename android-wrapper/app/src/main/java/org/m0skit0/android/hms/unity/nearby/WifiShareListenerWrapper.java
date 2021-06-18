package org.m0skit0.android.hms.unity.nearby;

import com.huawei.hms.nearby.discovery.ScanEndpointInfo;

public class WifiShareListenerWrapper extends com.huawei.hms.nearby.wifishare.WifiShareCallback {

    private final WifiShareListener listener;

    public WifiShareListenerWrapper(final WifiShareListener listener) {
        super();
        this.listener = listener;
    }
    @Override
    public void onFound(String endpointId, ScanEndpointInfo scanEndpointInfo) {
        listener.onFound( endpointId,   scanEndpointInfo);
    }
    @Override
    public void onLost(String endpointId) {
        listener.onLost(endpointId);
    }
    @Override
    public void onFetchAuthCode(String endpointId, String authCode) {
        listener.onFetchAuthCode( endpointId,   authCode);
    }
    @Override
    public void onWifiShareResult(String endpointId,int statusCode) {
        listener.onWifiShareResult( endpointId,   statusCode);
    }
 }
