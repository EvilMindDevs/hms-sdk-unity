package org.m0skit0.android.hms.unity.location;

import android.app.Activity;
import android.app.PendingIntent;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.location.Location;
import android.util.Log;

import com.huawei.hms.location.Geofence;
import com.huawei.hms.location.GeofenceData;

import java.util.List;

public class GeoFenceBroadcastReceiver extends BroadcastReceiver {
    public static final String ACTION_PROCESS_LOCATION =
            "com.huawei.hmssample.geofence.GeoFenceBroadcastReceiver.ACTION_PROCESS_LOCATION";

    private static final String TAG = "GeoFenceReceiver";
    public static GeofenceData geofenceData;

    @Override
    public void onReceive(Context context, Intent intent) {
        Log.d(TAG, "Enes1 onReceive0 JAVA");
        if (intent != null) {
            Log.d(TAG, "Enes1 onReceive1 JAVA");
            final String action = intent.getAction();
            if (ACTION_PROCESS_LOCATION.equals(action)) {
                // Obtain the GeofenceData object from the intent.
                geofenceData = GeofenceData.getDataFromIntent(intent);
                Log.d(TAG, "Enes1 onReceive2 JAVA");

                if (geofenceData != null) {
                    Log.d(TAG, "Enes1 geofenceData != null JAVA");

                    // Obtain a result code.
                    int errorCode = geofenceData.getErrorCode();
                    // Obtain the geofence trigger type.
                    int conversion = geofenceData.getConversion();
                    // Obtain information about the triggered geofence.
                    List<Geofence> list = geofenceData.getConvertingGeofenceList();
                    // Obtain information about the location when the geofence is triggered.
                    Location mLocation = geofenceData.getConvertingLocation();
                    // Check whether the geofence event is triggered normally. If false is returned, an error has occurred.
                    boolean status = geofenceData.isSuccess();
                    // TODO: Processing based on returned geofence information.
                }
            }
        }
    }

    public static GeofenceData getGeofenceData() {
        return geofenceData;
    }

    // Obtain PendingIntent associated with the custom static broadcast class LocationBroadcastReceiver.
    public static PendingIntent getPendingIntent(Activity unityActivity) {
        Intent intent = new Intent(unityActivity, GeoFenceBroadcastReceiver.class);
        intent.setAction(GeoFenceBroadcastReceiver.ACTION_PROCESS_LOCATION);
        return PendingIntent.getBroadcast(unityActivity, 0, intent, PendingIntent.FLAG_UPDATE_CURRENT);
    }
}



