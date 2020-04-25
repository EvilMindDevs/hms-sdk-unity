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
        super.onMessageReceived(remoteMessage);
        Log.d(TAG, "[HMS] onMessageReceived");
        if (listener != null) {
            listener.onMessageReceived(remoteMessage);
        }
    }

    @Override
    public void onNewToken(String token) {
        super.onNewToken(token);
        Log.d(TAG, "[HMS] onNewToken");
        if (listener != null) {
            listener.onNewToken(token);
        }
    }

    @Override
    public void onTokenError(Exception e) {
        super.onTokenError(e);
        Log.d(TAG, "[HMS] onTokenError");
        if (listener != null) {
            listener.onTokenError(e);
        }
    }
}
