package org.m0skit0.android.hms.unity.location;

import android.app.Activity;
import android.app.PendingIntent;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.os.Handler;
import android.os.Looper;
import android.util.Log;

public class LocationBroadcastReceiver extends BroadcastReceiver {

    public static final String ACTION_PROCESS_LOCATION = "com.huawei.hms.location.ACTION_PROCESS_LOCATION";
    private static final String TAG = "LocationReceiver";

    private static BroadcastWrapper locationBroadcastWrapper;

    private static Handler mainThreadHandler = new Handler(Looper.getMainLooper());

    public static PendingIntent getPendingIntent(Activity unityActivity) {
        Intent intent = new Intent(unityActivity, LocationBroadcastReceiver.class);
        intent.setAction(LocationBroadcastReceiver.ACTION_PROCESS_LOCATION);

        return PendingIntent.getBroadcast(unityActivity, 0, intent, PendingIntent.FLAG_UPDATE_CURRENT);
    }

    public static void setLocationBroadcastListener(final BroadcastWrapper listener) {
        Log.d(TAG, "setLocationBroadcastListener called");
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                locationBroadcastWrapper = listener;
            }
        });
    }

    @Override
    public void onReceive(Context context, final Intent intent) {
        if (intent != null) {
            final String action = intent.getAction();
            if (ACTION_PROCESS_LOCATION.equals(action)) {
                mainThreadHandler.post(new Runnable() {
                    @Override
                    public void run() {
                        if (locationBroadcastWrapper != null) {
                            locationBroadcastWrapper.onReceive(intent);
                        }
                    }
                });
            }
        }
    }
}
