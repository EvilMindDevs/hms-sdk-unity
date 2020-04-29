package org.m0skit0.android.hms.unity;

import android.util.Log;

import com.huawei.agconnect.config.AGConnectServicesConfig;
import com.huawei.hms.aaid.HmsInstanceId;
import com.huawei.hms.common.ApiException;
import com.unity3d.player.UnityPlayer;

public class DebugHelper {

    private static final String TAG = DebugHelper.class.getSimpleName();

    public static void printAppId() {
        final String appId = AGConnectServicesConfig.fromContext(UnityPlayer.currentActivity).getString("client/app_id");
        Log.d(TAG, "[HMS] printAppId: " + appId);
    }

    public static void printPushToken() throws ApiException {
        final String token = HmsInstanceId.getInstance(UnityPlayer.currentActivity).getToken("101282883", "HCM");
        Log.d(TAG, "[HMS] printPushToken: " + token);
    }
}
