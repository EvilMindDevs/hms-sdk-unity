package org.m0skit0.android.hms.unity.push;

import android.util.Log;

import com.huawei.hms.push.HmsMessageService;
import com.huawei.hms.push.RemoteMessage;

public class HMSPushService extends HmsMessageService {

    private static final String TAG = HMSPushService.class.getSimpleName();

    private static PushListener listener;

    public static void setListener(final PushListener listener) {
        HMSPushService.listener = listener;
    }

    @Override
    public void onMessageReceived(RemoteMessage remoteMessage) {
        Log.d(TAG, "[HMS] onMessageReceived");
        super.onMessageReceived(remoteMessage);
        if (listener != null) {
            listener.onMessageReceived(remoteMessage);
        }
    }

    @Override
    public void onNewToken(String token) {
        Log.d(TAG, "[HMS] onNewToken");
        super.onNewToken(token);
        if (listener != null) {
            listener.onNewToken(token);
        }
    }

    @Override
    public void onTokenError(Exception e) {
        Log.d(TAG, "[HMS] onTokenError");
        super.onTokenError(e);
        if (listener != null) {
            listener.onTokenError(e);
        }
    }
}
