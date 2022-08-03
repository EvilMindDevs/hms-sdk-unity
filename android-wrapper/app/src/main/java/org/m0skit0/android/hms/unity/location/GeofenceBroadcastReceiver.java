package org.m0skit0.android.hms.unity.location;

import android.app.Activity;
import android.app.PendingIntent;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.os.Handler;
import android.os.Looper;
import android.util.Log;

public class GeofenceBroadcastReceiver extends BroadcastReceiver {
    public static final String ACTION_PROCESS_LOCATION =
            "com.huawei.hmssample.geofence.GeoFenceBroadcastReceiver.ACTION_PROCESS_LOCATION";

    private static final String TAG = "GeofenceReceiver";
    private static Handler mainThreadHandler = new Handler(Looper.getMainLooper());
    private static BroadcastWrapper geofenceBroadcastWrapper;

    public static PendingIntent getPendingIntent(Activity unityActivity) {
        Intent intent = new Intent(unityActivity, GeofenceBroadcastReceiver.class);
        intent.setAction(GeofenceBroadcastReceiver.ACTION_PROCESS_LOCATION);
        return PendingIntent.getBroadcast(unityActivity, 0, intent, PendingIntent.FLAG_UPDATE_CURRENT);
    }

    public static void setGeofenceBroadcastListener(final BroadcastWrapper listener) {
        Log.d(TAG, "setGeofenceBroadcastListener called");
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                geofenceBroadcastWrapper = listener;
            }
        });
    }

    @Override
    public void onReceive(Context context, final Intent intent) {
        Log.d(TAG, "onReceive");
        if (intent != null) {
            final String action = intent.getAction();
            if (ACTION_PROCESS_LOCATION.equals(action)) {
                mainThreadHandler.post(new Runnable() {
                    @Override
                    public void run() {
                        if (geofenceBroadcastWrapper != null) {
                            geofenceBroadcastWrapper.onReceive(intent);
                        }
                    }
                });
            }
        }
    }
}



