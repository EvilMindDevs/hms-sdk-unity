package org.m0skit0.android.hms.unity.appLinking;

import android.content.Context;
import android.content.Intent;
import android.util.Log;

import com.huawei.agconnect.applinking.AGConnectAppLinking;
import com.huawei.agconnect.applinking.ResolvedLinkData;
import com.huawei.agconnect.config.AGConnectServicesConfig;
import com.huawei.agconnect.config.LazyInputStream;
import com.unity3d.player.UnityPlayer;

import java.io.IOException;
import java.io.InputStream;

public class AppLinking {

    private static final String TAG = "AppLinking";

    private static AGConnectAppLinking agConnectAppLinking = null;

    public static AGConnectAppLinking getInstance() {
        if (agConnectAppLinking == null) {
            AGConnectServicesConfig config = AGConnectServicesConfig.fromContext(UnityPlayer.currentActivity);
            config.overlayWith(new LazyInputStream(UnityPlayer.currentActivity) {
                public InputStream get(Context context) {
                    try {
                        return context.getAssets().open("agconnect-services.json");
                    } catch (IOException e) {
                        Log.e(TAG, "Error occurred when opening agconnect file");
                        return null;
                    }
                }
            });
            agConnectAppLinking = AGConnectAppLinking.getInstance();
        }
        return agConnectAppLinking;
    }

    public static void shareLink(String agcLink) {
        if (agcLink != null) {
            Intent intent = new Intent(Intent.ACTION_SEND);
            intent.setType("text/plain");
            intent.putExtra(Intent.EXTRA_TEXT, agcLink);
            intent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
            UnityPlayer.currentActivity.startActivity(intent);
        }
    }

    public static int getLinkType(ResolvedLinkData resolvedLinkData) {
        Log.d(TAG, "Link type = " + resolvedLinkData.getLinkType().name());
        return resolvedLinkData.getLinkType().ordinal();
    }


}
