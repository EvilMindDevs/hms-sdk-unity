package org.m0skit0.android.hms.unity.push;

import android.os.Bundle;

import com.huawei.hms.push.RemoteMessage;

public interface PushListener {
    void onNewToken(String token);
    void onNewToken(String token, Bundle bundle);
    void onTokenError(Exception e);
    void onTokenError(Exception exception, Bundle bundle);
    void onMessageReceived(RemoteMessage remoteMessage);
    void onMessageSent(String msgId);
    void onMessageDelivered(String msgId, Exception exception);
    void onSendError(String msgId, Exception exception);
}
