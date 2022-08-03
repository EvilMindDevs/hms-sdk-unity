package org.m0skit0.android.hms.unity.location;

import com.huawei.hms.location.LocationAvailability;
import com.huawei.hms.location.LocationResult;

public interface LocationCallbackListener {

    void onLocationResult(LocationResult locationResult);
    void onLocationAvailability(LocationAvailability locationAvailability);

}
