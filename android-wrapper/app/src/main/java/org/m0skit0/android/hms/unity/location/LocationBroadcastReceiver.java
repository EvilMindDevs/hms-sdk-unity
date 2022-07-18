package org.m0skit0.android.hms.unity.location;

import android.Manifest;
import android.app.Activity;
import android.app.PendingIntent;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.util.Log;

import androidx.core.app.ActivityCompat;

import com.huawei.hms.location.ActivityConversionData;
import com.huawei.hms.location.ActivityConversionResponse;
import com.huawei.hms.location.ActivityIdentificationData;
import com.huawei.hms.location.ActivityIdentificationResponse;

import java.util.List;

public class LocationBroadcastReceiver extends BroadcastReceiver {

    public static final String ACTION_PROCESS_LOCATION = "com.huawei.hms.location.ACTION_PROCESS_LOCATION";
    private static final String TAG = "LocationReceiver";

    public static List<ActivityIdentificationData> activityList;
    public static List<ActivityConversionData> conversionDataList;
    public static ActivityIdentificationResponse activityIdentificationResponse;
    public static ActivityConversionResponse activityConversionResponse;

    @Override
    public void onReceive(Context context, Intent intent) {
        Log.d(TAG, "Enes onReceive1 JAVA");
        if (intent != null) {
            final String action = intent.getAction();
            if (ACTION_PROCESS_LOCATION.equals(action)) {

                activityIdentificationResponse = ActivityIdentificationResponse.getDataFromIntent(intent);
                activityConversionResponse = ActivityConversionResponse.getDataFromIntent(intent);
                Log.d(TAG, "Enes onReceive2 JAVA");
                if (activityIdentificationResponse != null) {
                    Log.d(TAG, "activityRecognitionResult:: " + activityIdentificationResponse);
                    activityList = activityIdentificationResponse.getActivityIdentificationDatas();
                    Log.d(TAG, "Enes onReceive3 JAVA");
                } else Log.e(TAG, "Enes activityIdentificationResponse is null JAVA");
                if (activityConversionResponse != null) {
                    conversionDataList = activityConversionResponse.getActivityConversionDatas();
                    Log.d(TAG, "activityConversionResponse result:: " + activityConversionResponse);
                } else Log.e(TAG, "Enes activityConversionResponse is null JAVA");
            }
        }
    }

    public static ActivityConversionResponse getActivityConversionResponse() {
        if (activityConversionResponse!=null)
        Log.d(TAG, "Enes ActivityConversionResponse JAVA"+ activityConversionResponse.toString());
        return activityConversionResponse;
    }
    public static ActivityIdentificationResponse getActivityIdentificationResponse() {
        if (activityIdentificationResponse!=null)
            Log.d(TAG, "Enes ActivityIdentificationResponse JAVA"+ activityIdentificationResponse.toString());
        return activityIdentificationResponse;
    }

    public static List<ActivityIdentificationData> getActivityList() {
        Log.d(TAG, "Enes getActivityList1 JAVA");
        if (activityList == null) return null;
        for (int i = 0; i < activityList.size(); i++) {
            Log.d(TAG, "Enes getActivityList1 JAVA " + activityList.get(i).toString());
        }
        return activityList;
    }

    public static List<ActivityConversionData> getConversionDataList() {
        Log.d(TAG, "Enes getActivityList1 JAVA");
        if (conversionDataList == null) return null;
        for (int i = 0; i < conversionDataList.size(); i++) {
            Log.d(TAG, "Enes getActivityList1 JAVA " + conversionDataList.get(i).toString());
        }
        return conversionDataList;
    }

    // Obtain PendingIntent associated with the custom static broadcast class LocationBroadcastReceiver.
    public static PendingIntent getPendingIntent(Activity unityActivity) {
        Log.d(TAG, "Enes PendingIntent2 JAVA");
        Intent intent = new Intent(unityActivity, LocationBroadcastReceiver.class);
        intent.setAction(LocationBroadcastReceiver.ACTION_PROCESS_LOCATION);
        Log.d(TAG, "Enes PendingIntent2 JAVA");

        return PendingIntent.getBroadcast(unityActivity, 0, intent, PendingIntent.FLAG_UPDATE_CURRENT);
    }

    public static void applyActivityRecognitionPermissions(Activity activity) {
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
