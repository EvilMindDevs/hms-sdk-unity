package org.m0skit0.android.hms.unity.location;

import com.huawei.hms.location.LocationAvailability;
import com.huawei.hms.location.LocationCallback;
import com.huawei.hms.location.LocationResult;

class LocationCallbackWrapper extends LocationCallback {

    private final LocationCallbackListener listener;

    public LocationCallbackWrapper(LocationCallbackListener listener) {
        super();
        this.listener = listener;
    }

    @Override
    public void onLocationResult(LocationResult locationResult) {
        listener.onLocationResult();
    }

    @Override
    public void onLocationAvailability(LocationAvailability locationAvailability) {
        listener.onLocationAvailability();
    }
}
