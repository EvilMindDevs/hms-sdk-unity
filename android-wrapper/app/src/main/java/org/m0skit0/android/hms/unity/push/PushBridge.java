package org.m0skit0.android.hms.unity.push;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;

public class PushBridge {

    private static NotificationListener listener;

    private static String TAG = "PushKitBridge";

    public static void setListener(final NotificationListener listener) {
        PushBridge.listener = listener;
    }

    public static void OnNotificationMessage(Intent intent) {
        if (intent == null) return;
        try {
            if (listener != null)
                listener.onNotificationMessage(getIntentData(intent));
        } catch (JSONException ex) {

        }
    }

    public static NotificationData getIntentData(Intent intent) throws JSONException {
        if (intent == null) return null;

        NotificationData notificationData = new NotificationData();
        notificationData.msgid = intent.getStringExtra("_push_msgid");
        notificationData.cmdType = intent.getStringExtra("_push_cmd_type");
        notificationData.notifyId = intent.getIntExtra("_push_notifyid", -1);

        Bundle bundle = intent.getExtras();
        if (bundle != null) {
            if (bundle.containsKey("_push_notifyid"))
                bundle.remove("_push_notifyid");
            if (bundle.containsKey("_push_msgid"))
                bundle.remove("_push_msgid");
            if (bundle.containsKey("_push_cmd_type"))
                bundle.remove("_push_cmd_type");
            if (bundle.containsKey("analyticInfo"))
                bundle.remove("analyticInfo");
            if (bundle.containsKey("_hw_from"))
                bundle.remove("_hw_from");
            if (bundle.containsKey("_push_data_version"))
                bundle.remove("_push_data_version");


            JSONObject obj = new JSONObject();

            for (String key : bundle.keySet()) {
                String content = bundle.getString(key);
                obj.put(key, content);
                Log.i(TAG, "receive data from push, key = " + key + ", content = " + content);
            }
            Log.i(TAG, obj.toString());
            notificationData.keyValueJson = obj.toString();
        }

        Log.i(TAG, "receive data from push, msgId = " + notificationData.msgid + ", cmd = " + notificationData.cmdType + ", notifyId = " + notificationData.notifyId);
        return notificationData;
    }

    public static NotificationData getNotificationDataOnStart(Activity unityActivity) throws JSONException {
        Intent intent = unityActivity.getIntent();
        if (intent == null) return null;
        return getIntentData(intent);
    }

    public static class NotificationData {
        public static String msgid;
        public static String cmdType;
        public static int notifyId;
        public static String keyValueJson;
    }
}
