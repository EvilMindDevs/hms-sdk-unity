package org.m0skit0.android.hms.unity.location;

import android.location.Location;
import android.os.Looper;
import android.util.Log;

import com.huawei.hms.location.LocationAvailability;
import com.huawei.hms.location.LocationCallback;
import com.huawei.hms.location.LocationResult;

import java.util.List;

public class LocationBridge {
    private static final String TAG = LocationBridge.class.getSimpleName();
    public static LocationCallback mLocationCallback;
    private static LocationResult locationResult;

    public static void getLocationResult() {
        Log.d(TAG, "Enes1 receiveShow");
        try {
            Log.d(TAG, "Enes1 receiveShow trt");
            mLocationCallback = new LocationCallback() {
                @Override
                public void onLocationResult(LocationResult locationResult) {
                    Log.i(TAG, "Enes1 3333");
                    if (locationResult != null) {
                        List<Location> locations = locationResult.getLocations();
                        if (!locations.isEmpty()) {
                            for (Location location : locations) {
                                Log.i(TAG, "location");
                                Log.i(TAG,
                                        "onLocationResult location[Longitude,Latitude,Accuracy]:" + location.getLongitude()
                                                + "," + location.getLatitude() + "," + location.getAccuracy());
                            }
                        }
                    }
                }
                @Override
                public void onLocationAvailability(LocationAvailability locationAvailability) {
                    Log.i(TAG, "Enes1 4444");

                    if (locationAvailability != null) {
                        Log.i(TAG, "Enes1 3355533");

                        boolean flag = locationAvailability.isLocationAvailable();
                        Log.i(TAG, "onLocationAvailability isLocationAvailable:" + flag);
                    }
                }
            };
            if (locationResult == null) Log.d(TAG, "Enes1 [locationResult] null");
        } catch (Exception e) {
            Log.d(TAG, "Enes1 [locationResult] dönemdi");
        }
        Log.d(TAG, "Enes1 Simdlik");
        //LocationBridge.callback = callback;
    }
}
