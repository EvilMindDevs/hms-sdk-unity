package org.m0skit0.android.hms.unity.nearby;

import com.huawei.hms.nearby.discovery.ConnectInfo;
import com.huawei.hms.nearby.discovery.ConnectResult;

public class NearbyListenerWrapper extends com.huawei.hms.nearby.discovery.ConnectCallback {

    private final NearbyListener listener;

    public NearbyListenerWrapper(final NearbyListener listener) {
        super();
        this.listener = listener;
    }

    @Override
    public void onEstablish(String s, ConnectInfo connectInfo) {
        listener.onEstablish(s, connectInfo);
    }

    @Override
    public void onResult(String s, ConnectResult connectResult) {
        listener.onResult(s, connectResult);
    }

    @Override
    public void onDisconnected(String s) {
        listener.onDisconnected(s);

    }
}
