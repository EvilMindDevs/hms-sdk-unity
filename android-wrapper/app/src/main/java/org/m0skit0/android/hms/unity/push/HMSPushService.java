package org.m0skit0.android.hms.unity.push;

import android.os.Bundle;
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
    @Override
    public void onNewToken(String token, Bundle bundle) {
        Log.d(TAG, "[HMS] onNewToken");
        super.onNewToken(token, bundle);
        if (listener != null) {
            listener.onNewToken(token, bundle);
        }
    }
    @Override
    public void onTokenError(Exception exception, Bundle bundle){
        Log.d(TAG, "[HMS] onTokenError");
        super.onTokenError(exception, bundle);
        if (listener != null) {
            listener.onTokenError(exception, bundle);
        }
    }
    @Override
    public void  onMessageSent(String msgId){
        Log.d(TAG, "[HMS] onMessageSent");
        super. onMessageSent(msgId);
        if (listener != null) {
            listener.onMessageSent( msgId);
        }
    }
    @Override
    public void onMessageDelivered(String msgId, Exception exception){
        Log.d(TAG, "[HMS] onMessageDelivered");
        super.onMessageDelivered(msgId, exception);
        if (listener != null) {
            listener.onMessageDelivered(msgId, exception);
        }
    }
    @Override
    public void  onSendError(String msgId, Exception exception){
        Log.d(TAG, "[HMS] onSendError");
        super.onSendError(msgId, exception);
        if (listener != null) {
            listener.onSendError(msgId, exception);
        }
    }
}
