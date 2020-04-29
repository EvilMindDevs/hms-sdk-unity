package org.m0skit0.android.hms.unity.helper;

import android.content.Context;
import android.content.pm.ApplicationInfo;
import android.content.pm.PackageManager;
import android.util.Log;

import com.unity3d.player.UnityPlayer;

public class MetadataHelper {

    private static final String TAG = MetadataHelper.class.getSimpleName();

    private static final String META_DATA_APP_ID = "com.huawei.hms.client.appid";

    public static String getAppId() throws PackageManager.NameNotFoundException {
        final Context context = UnityPlayer.currentActivity;
        final ApplicationInfo applicationInfo = context.getPackageManager()
                .getApplicationInfo(context.getPackageName(), PackageManager.GET_META_DATA);
        final String appIdMetaData = applicationInfo.metaData.getString(META_DATA_APP_ID);
        if (appIdMetaData == null) {
            return null;
        }
        return appIdMetaData.split("=")[1];
    }
}
