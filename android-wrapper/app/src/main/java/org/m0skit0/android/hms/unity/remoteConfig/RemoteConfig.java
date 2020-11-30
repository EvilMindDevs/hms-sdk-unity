package org.m0skit0.android.hms.unity.remoteConfig;

import android.content.Context;

import com.huawei.agconnect.config.AGConnectServicesConfig;
import com.huawei.agconnect.config.LazyInputStream;
import com.huawei.agconnect.remoteconfig.AGConnectConfig;
import com.unity3d.player.UnityPlayer;

import java.io.IOException;
import java.io.InputStream;

public class RemoteConfig {
    private static final String TAG = "RemoteConfig";

    private static AGConnectConfig agConnectConfig = null;

    public static AGConnectConfig getInstance() {
        if (agConnectConfig == null) {
            AGConnectServicesConfig config = AGConnectServicesConfig.fromContext(UnityPlayer.currentActivity);
            config.overlayWith(new LazyInputStream(UnityPlayer.currentActivity) {
                public InputStream get(Context context) {
                    try {
                        return context.getAssets().open("agconnect-services.json");
                    } catch (IOException e) {
                        return null;
                    }
                }
            });
            agConnectConfig = AGConnectConfig.getInstance();
        };
        return agConnectConfig;
    }
}
