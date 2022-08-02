package org.m0skit0.android.hms.unity.ads.installreferrer.bridge;

import android.os.Handler;
import android.os.Looper;
import android.util.Log;

import com.huawei.hms.ads.installreferrer.api.InstallReferrerClient;
import com.huawei.hms.ads.installreferrer.api.InstallReferrerStateListener;

public class InstallReferrerStateBridge {

    private static final String TAG = InstallReferrerStateBridge.class.getSimpleName();

    private static InstallReferrerStateCallbackWrapper installReferrerStateCallbackWrapper;

    private static Handler mainThreadHandler = new Handler(Looper.getMainLooper());

    private static InstallReferrerStateListener installReferrerStateListener;

    public static void setInstallReferrerCallbackListener(final InstallReferrerStateCallbackWrapper listener) {
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                installReferrerStateCallbackWrapper = listener;
                Log.d(TAG, "setInstallReferrerCallbackListener called");
            }
        });
    }

    public static InstallReferrerStateListener getInstallReferrerStateListener() {

        try {

            installReferrerStateListener = new InstallReferrerStateListener() {
                @Override
                public void onInstallReferrerSetupFinished(final int responseCode) {

                    mainThreadHandler.post(new Runnable() {
                        @Override
                        public void run() {
                            if (installReferrerStateCallbackWrapper != null) {
                                installReferrerStateCallbackWrapper.onInstallReferrerSetupFinished(responseCode);
                            }
                        }
                    });

                    switch (responseCode) {
                        case InstallReferrerClient.InstallReferrerResponse.OK:
                            Log.i(TAG, "connect ads kit ok");
                            break;
                        case InstallReferrerClient.InstallReferrerResponse.FEATURE_NOT_SUPPORTED:
                            // Service not supported. Please download and install the latest version of Huawei Mobile Services(APK).
                            Log.i(TAG, "FEATURE_NOT_SUPPORTED");
                            break;
                        case InstallReferrerClient.InstallReferrerResponse.SERVICE_UNAVAILABLE:
                            // Service unavailable. Please update the version of Huawei Mobile Services(APK) to 2.6.5 or later.
                            Log.i(TAG, "SERVICE_UNAVAILABLE");
                            break;
                        default:
                            Log.i(TAG, "responseCode: " + responseCode);
                            break;
                    }
                }

                @Override
                public void onInstallReferrerServiceDisconnected() {
                    Log.i(TAG, "onInstallReferrerServiceDisconnected");

                    mainThreadHandler.post(new Runnable() {
                        @Override
                        public void run() {
                            if (installReferrerStateCallbackWrapper != null) {
                                installReferrerStateCallbackWrapper.onInstallReferrerServiceDisconnected();
                            }
                        }
                    });

                }
            };

        } catch (Exception exception) {
            Log.d(TAG, exception.getMessage());
        }
        return installReferrerStateListener;

    }
}
