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
        if (ActivityCompat.checkSelfPermission(activity,
                "android.permission.ACCESS_BACKGROUND_LOCATION") != PackageManager.PERMISSION_GRANTED) {
            String[] permissions = {"android.permission.ACCESS_BACKGROUND_LOCATION"};
                ActivityCompat.requestPermissions(activity, permissions, 0);
        }
    }

    //todo delete this
    public static void requestLocationPermission(Context context) {
        // check location permisiion
        if (Build.VERSION.SDK_INT <= Build.VERSION_CODES.P) {
            Log.i(TAG, "android sdk < 28 Q");
            if (ActivityCompat.checkSelfPermission(context,
                    Manifest.permission.ACCESS_FINE_LOCATION) != PackageManager.PERMISSION_GRANTED
                    && ActivityCompat.checkSelfPermission(context,
                    Manifest.permission.ACCESS_COARSE_LOCATION) != PackageManager.PERMISSION_GRANTED) {
                String[] strings =
                        {Manifest.permission.ACCESS_FINE_LOCATION, Manifest.permission.ACCESS_COARSE_LOCATION};
                if (context instanceof Activity) {
                    ActivityCompat.requestPermissions((Activity) context, strings, 1);
                }
            }
        } else {
            if (ActivityCompat.checkSelfPermission(context,
                    Manifest.permission.ACCESS_FINE_LOCATION) != PackageManager.PERMISSION_GRANTED
                    && ActivityCompat.checkSelfPermission(context,
                    Manifest.permission.ACCESS_COARSE_LOCATION) != PackageManager.PERMISSION_GRANTED
                    && ActivityCompat.checkSelfPermission(context,
                    "android.permission.ACCESS_BACKGROUND_LOCATION") != PackageManager.PERMISSION_GRANTED) {
                String[] strings = {Manifest.permission.ACCESS_FINE_LOCATION,
                        Manifest.permission.ACCESS_COARSE_LOCATION, "android.permission.ACCESS_BACKGROUND_LOCATION"};
                if (context instanceof Activity) {
                    ActivityCompat.requestPermissions((Activity) context, strings, 2);
                }
            }
        }
    }
    public static void requestActivityRecognitionPermissions(Activity activity) {
        Log.d(TAG, "Enes applyActivityRecognitionPermissions1 JAVA");
        final String[] permissions = new String[]{Manifest.permission.ACTIVITY_RECOGNITION, "com.huawei.hms.permission.ACTIVITY_RECOGNITION"};
        if (!ActivityCompat.shouldShowRequestPermissionRationale(activity, Manifest.permission.ACTIVITY_RECOGNITION)) {
            ActivityCompat.requestPermissions(activity, permissions, 1);
            Log.d(TAG, "Enes applyActivityRecognitionPermissions2 JAVA");
        }
        if (!ActivityCompat.shouldShowRequestPermissionRationale(activity, "com.huawei.hms.permission.ACTIVITY_RECOGNITION")) {
            ActivityCompat.requestPermissions(activity, permissions, 1);
            Log.d(TAG, "Enes applyActivityRecognitionPermissions3 JAVA");
        }
        Log.d(TAG, "Enes applyActivityRecognitionPermissions4 JAVA");
    }
}
