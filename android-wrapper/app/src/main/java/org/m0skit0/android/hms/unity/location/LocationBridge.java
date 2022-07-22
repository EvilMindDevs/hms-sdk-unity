package org.m0skit0.android.hms.unity.location;

import android.os.Handler;
import android.os.Looper;
import android.util.Log;

import com.huawei.hms.location.LocationAvailability;
import com.huawei.hms.location.LocationCallback;
import com.huawei.hms.location.LocationResult;

public class LocationBridge {
    private static final String TAG = LocationBridge.class.getSimpleName();
    public static LocationCallback mLocationCallback;
    private static LocationCallbackWrapper locationCallbackWrapper;

    private static Handler mainThreadHandler = new Handler(Looper.getMainLooper());

    public static void setLocationCallbackListener(final LocationCallbackWrapper listener) {
        Log.d(TAG, "setLocationCallbackListener called");
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                locationCallbackWrapper = listener;
            }
        });
    }

    public static LocationCallback getLocationResult() {
        try {
            mLocationCallback = new LocationCallback() {
                @Override
                public void onLocationResult(final LocationResult locationResult) {
                    Log.i(TAG, "onLocationResult called");
                    if (locationResult != null) {
                        mainThreadHandler.post(new Runnable() {
                            @Override
                            public void run() {
                                if (locationCallbackWrapper != null) {
                                    locationCallbackWrapper.onLocationResult(locationResult);
                                }
                            }
                        });
                    }
                }

                @Override
                public void onLocationAvailability(final LocationAvailability locationAvailability) {
                    Log.i(TAG, "onLocationAvailability called");
                    if (locationAvailability != null) {
                        mainThreadHandler.post(new Runnable() {
                            @Override
                            public void run() {
                                if (locationCallbackWrapper != null)
                                    locationCallbackWrapper.onLocationAvailability(locationAvailability);
                            }
                        });
                    }
                }
            };
        } catch (Exception exception) {
            Log.d(TAG, exception.getMessage());
        }
        return mLocationCallback;
    }
}
