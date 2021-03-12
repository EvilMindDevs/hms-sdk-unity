package org.m0skit0.android.hms.unity.nearby;

import com.huawei.hms.nearby.discovery.ScanEndpointInfo;

public class StatusListenerWrapper extends com.huawei.hms.nearby.message.StatusCallback{
    private final StatusListener listener;

    public StatusListenerWrapper(final StatusListener listener) {
        super();
        this.listener = listener;
    }
    @Override
    public void onPermissionChanged(boolean grantPermission) {
        listener.onPermissionChanged( grantPermission);
    }

}

