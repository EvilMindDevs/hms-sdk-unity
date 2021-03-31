package org.m0skit0.android.hms.unity.nearby;

import com.huawei.hms.nearby.discovery.ConnectInfo;
import com.huawei.hms.nearby.discovery.ConnectResult;

public interface NearbyListener {
    void onEstablish(String p0,  ConnectInfo p1);
    void onResult(String p0, ConnectResult p1);
    void onDisconnected(String p0);
}
