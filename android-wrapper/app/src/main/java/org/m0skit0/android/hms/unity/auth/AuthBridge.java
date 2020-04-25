package org.m0skit0.android.hms.unity.auth;

import android.content.Intent;
import android.util.Log;

import org.m0skit0.android.hms.unity.GenericBridgeCallback;
import org.m0skit0.android.hms.unity.activity.NativeBridgeActivity;

public class AuthBridge {

    private static final String TAG = AuthBridge.class.getSimpleName();

    public static final int CODE = 1;
    public static final String AUTH = "AUTH";

    private static Intent intent;
    private static GenericBridgeCallback callback;

    public static void receiveStartSignIn(final Intent intent, final GenericBridgeCallback callback) {
        Log.d(TAG, "[HMS] receiveStartSignIn");
        AuthBridge.intent = intent;
        AuthBridge.callback = callback;
        NativeBridgeActivity.start(AUTH);
    }

    public static void launchStartSignIn(final NativeBridgeActivity activity) {
        Log.d(TAG, "[HMS] launchStartSignIn");
        activity.startActivityForResult(intent, CODE);
    }

    public static void returnStartSignIn(final Intent data) {
        Log.d(TAG, "[HMS] returnStartSignIn");
        callback.onSuccess(data);
    }
}
