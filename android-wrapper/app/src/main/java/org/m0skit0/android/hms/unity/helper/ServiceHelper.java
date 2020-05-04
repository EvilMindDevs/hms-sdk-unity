package org.m0skit0.android.hms.unity.helper;

import com.google.android.gms.common.ConnectionResult;
import com.google.android.gms.common.GoogleApiAvailability;
import com.huawei.hms.api.HuaweiApiAvailability;
import com.unity3d.player.UnityPlayer;

public class ServiceHelper {

    public static boolean isGMSAvailable() {
        return GoogleApiAvailability.getInstance().isGooglePlayServicesAvailable(UnityPlayer.currentActivity)
                == ConnectionResult.SUCCESS;
    }

    public static boolean isHMSAvailable() {
        return HuaweiApiAvailability.getInstance().isHuaweiMobileServicesAvailable(UnityPlayer.currentActivity)
                == com.huawei.hms.api.ConnectionResult.SUCCESS;
    }
}
