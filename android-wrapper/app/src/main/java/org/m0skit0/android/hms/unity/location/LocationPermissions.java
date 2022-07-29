package org.m0skit0.android.hms.unity.location;

import android.Manifest;
import android.app.Activity;
import android.content.Context;
import android.content.pm.PackageManager;
import android.os.Build;
import android.util.Log;

import androidx.core.app.ActivityCompat;

public class LocationPermissions {

    private static final String TAG = "LocationPermissions";

    public static void requestBackgroundLocationPermissions(Activity activity) {
        Log.d(TAG, "requestBackgroundLocationPermissions called");
        if (ActivityCompat.checkSelfPermission(activity,
                "android.permission.ACCESS_BACKGROUND_LOCATION") != PackageManager.PERMISSION_GRANTED) {
            String[] permissions = {"android.permission.ACCESS_BACKGROUND_LOCATION"};
            ActivityCompat.requestPermissions(activity, permissions, 0);
        }
    }

     public static void requestActivityRecognitionPermissions(Activity activity) {
         Log.d(TAG, "requestActivityRecognitionPermissions called");
         final String[] permissions = new String[]{Manifest.permission.ACTIVITY_RECOGNITION, "com.huawei.hms.permission.ACTIVITY_RECOGNITION"};
        if (!ActivityCompat.shouldShowRequestPermissionRationale(activity, Manifest.permission.ACTIVITY_RECOGNITION)) {
            ActivityCompat.requestPermissions(activity, permissions, 1);
        }
        if (!ActivityCompat.shouldShowRequestPermissionRationale(activity, "com.huawei.hms.permission.ACTIVITY_RECOGNITION")) {
            ActivityCompat.requestPermissions(activity, permissions, 1);
        }
    }
}
