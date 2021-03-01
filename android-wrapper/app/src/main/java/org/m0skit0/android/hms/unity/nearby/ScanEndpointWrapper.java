package org.m0skit0.android.hms.unity.nearby;

import com.huawei.hms.nearby.discovery.ScanEndpointInfo;

public class ScanEndpointWrapper extends com.huawei.hms.nearby.discovery.ScanEndpointCallback {

    private final ScanEndpointListener listener;

    public ScanEndpointWrapper(final ScanEndpointListener listener) {
        super();
        this.listener = listener;
    }
    @Override
    public void onFound(String s, ScanEndpointInfo scanEndpointInfo) {
        listener.onFound( s,   scanEndpointInfo);
    }
    @Override
    public void onLost(String s) {
        listener.onLost(s);
    }
}
