package org.m0skit0.android.hms.unity.location;

import com.huawei.hms.location.LocationAvailability;
import com.huawei.hms.location.LocationCallback;
import com.huawei.hms.location.LocationResult;

public class LocationCallbackWrapper extends LocationCallback {

    private final LocationCallbackListener listener;

    public LocationCallbackWrapper(LocationCallbackListener listener) {
        super();
        this.listener = listener;
    }

    @Override
    public void onLocationResult(LocationResult locationResult)
    {
        super.onLocationResult(locationResult);
        listener.onLocationResult(locationResult);
    }

    @Override
    public void onLocationAvailability(LocationAvailability locationAvailability) {
        super.onLocationAvailability(locationAvailability);
        listener.onLocationAvailability(locationAvailability);
    }
}
