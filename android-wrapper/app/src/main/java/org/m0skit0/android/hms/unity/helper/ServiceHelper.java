package org.m0skit0.android.hms.unity.helper;

import android.app.Activity;
import android.content.Context;
import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;

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
    public static String getHMSCoreVersionName() {

        PackageInfo pinfo = null;
        try {
            pinfo =  UnityPlayer.currentActivity.getPackageManager().getPackageInfo("com.huawei.hwid", 0);
        } catch (PackageManager.NameNotFoundException e) {
            e.printStackTrace();
        }
        //getVersionName is Deprecated, instead use versionName
        String verName = pinfo.versionName;
        return  verName;
    }
    public static int getServicesVersionCode(){
        return HuaweiApiAvailability.getInstance().getServicesVersionCode();
    }

    public static void setServicesVersionCode(int var0){
        HuaweiApiAvailability.getInstance().setServicesVersionCode(var0);
    }

    public static int isHuaweiMobileServicesAvailable(){
        return HuaweiApiAvailability.getInstance().isHuaweiMobileServicesAvailable(UnityPlayer.currentActivity);
    }

    public static int isHuaweiMobileServicesAvailable(int var2){
        return HuaweiApiAvailability.getInstance().isHuaweiMobileServicesAvailable(UnityPlayer.currentActivity,var2);
    }

    public static int isHuaweiMobileNoticeAvailable(Context var1){
        return HuaweiApiAvailability.getInstance().isHuaweiMobileNoticeAvailable(var1);
    }

    public static boolean isUserResolvableError(int var1){
        return HuaweiApiAvailability.getInstance().isUserResolvableError(var1);
    }

    public static void resolveError(Activity var1, int var2, int var3){
        HuaweiApiAvailability.getInstance().resolveError(var1,var2,var3);
    }

    public static String getErrorString(int var1) {
        return HuaweiApiAvailability.getInstance().getErrorString(var1);
    }

    public static void showErrorNotification(Context var1, int var2){
        HuaweiApiAvailability.getInstance().showErrorNotification(var1,var2);
    }

    public static final String APPID_HMS =  HuaweiApiAvailability.getInstance().APPID_HMS;
    public static final String APPID_HMS_TV =  HuaweiApiAvailability.getInstance().APPID_HMS_TV;
    public static final int NOTICE_VERSION_CODE =  HuaweiApiAvailability.getInstance().NOTICE_VERSION_CODE;
    public static final int HMS_VERSION_MIN =  HuaweiApiAvailability.getInstance().HMS_VERSION_MIN;
    public static final int HMS_JSON_VERSION_MIN =  HuaweiApiAvailability.getInstance().HMS_JSON_VERSION_MIN;
    public static final int HMS_VERSION_MAX =  HuaweiApiAvailability.getInstance().HMS_VERSION_MAX;
    public static final int HMS_VERSION_CODE_MIN =  HuaweiApiAvailability.getInstance().HMS_VERSION_CODE_MIN;
    public static final String HMS_API_NAME_ID =  HuaweiApiAvailability.getInstance().HMS_API_NAME_ID;
    public static final int HMS_VERSION_CODE_ID =  HuaweiApiAvailability.getInstance().HMS_VERSION_CODE_ID;
    public static final String HMS_API_NAME_SNS =  HuaweiApiAvailability.getInstance().HMS_API_NAME_SNS;
    public static final int HMS_VERSION_CODE_SNS =  HuaweiApiAvailability.getInstance().HMS_VERSION_CODE_SNS;
    public static final String HMS_API_NAME_PAY =  HuaweiApiAvailability.getInstance().HMS_API_NAME_PAY;
    public static final int HMS_VERSION_CODE_PAY =  HuaweiApiAvailability.getInstance().HMS_VERSION_CODE_PAY;
    public static final String HMS_API_NAME_PUSH =  HuaweiApiAvailability.getInstance().HMS_API_NAME_PUSH;
    public static final int HMS_VERSION_CODE_PUSH =  HuaweiApiAvailability.getInstance().HMS_VERSION_CODE_PUSH;
    public static final String HMS_API_NAME_GAME =  HuaweiApiAvailability.getInstance().HMS_API_NAME_GAME;
    public static final int HMS_VERSION_CODE_GAME =  HuaweiApiAvailability.getInstance().HMS_VERSION_CODE_GAME;
    public static final String HMS_API_NAME_OD =  HuaweiApiAvailability.getInstance().HMS_API_NAME_OD;
    public static final int HMS_VERSION_CODE_OD =  HuaweiApiAvailability.getInstance().HMS_VERSION_CODE_OD;
    public static final String HMS_API_NAME_IAP =  HuaweiApiAvailability.getInstance().HMS_API_NAME_IAP;
    public static final int HMS_VERSION_CODE_IAP =  HuaweiApiAvailability.getInstance().HMS_VERSION_CODE_IAP;
    public static final String HMS_API_NAME_PPS =  HuaweiApiAvailability.getInstance().HMS_API_NAME_PPS;
    public static final int HMS_VERSION_CODE_PPS =  HuaweiApiAvailability.getInstance().HMS_VERSION_CODE_PPS;
    public static int SERVICES_VERSION_CODE =  HuaweiApiAvailability.getInstance().SERVICES_VERSION_CODE;
    public static final int HMS_SDK_VERSION_CODE =  HuaweiApiAvailability.getInstance().HMS_SDK_VERSION_CODE;
    public static final String HMS_SDK_VERSION_NAME =  HuaweiApiAvailability.getInstance().HMS_SDK_VERSION_NAME;
}