package org.m0skit0.android.hms.unity;

import android.content.Context;
import android.content.pm.ApplicationInfo;
import android.content.pm.PackageManager;
import android.util.Log;

import com.huawei.agconnect.config.AGConnectServicesConfig;
import com.huawei.hms.aaid.HmsInstanceId;
import com.huawei.hms.common.ApiException;
import com.unity3d.player.UnityPlayer;

public class DebugHelper {

    private static final String TAG = DebugHelper.class.getSimpleName();

    private static final String META_DATA_APP_ID = "com.huawei.hms.client.appid";

    public static void printAppIdFromAGConnectServicesConfig() {
        final String appId = AGConnectServicesConfig.fromContext(UnityPlayer.currentActivity).getString("client/app_id");
        Log.d(TAG, "[HMS] printAppIdFromAGConnectServicesConfig: " + appId);
    }

    public static void printPushToken() throws ApiException {
        final String token = HmsInstanceId.getInstance(UnityPlayer.currentActivity).getToken("101282883", "HCM");
        Log.d(TAG, "[HMS] printPushToken: " + token);
    }

    public static void printAppIdFromManifest() throws PackageManager.NameNotFoundException {
        final Context context = UnityPlayer.currentActivity;
        final ApplicationInfo applicationInfo = context.getPackageManager()
                .getApplicationInfo(context.getPackageName(), PackageManager.GET_META_DATA);
        final String appIdMetaData = applicationInfo.metaData.getString(META_DATA_APP_ID);
        Log.d(TAG, "[HMS] printAppIdFromManifest: " + appIdMetaData.split("=")[1]);
    }
}
