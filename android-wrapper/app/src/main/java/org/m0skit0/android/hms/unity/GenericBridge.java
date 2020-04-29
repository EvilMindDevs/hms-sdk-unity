package org.m0skit0.android.hms.unity;

import android.content.Intent;
import android.util.Log;

import org.m0skit0.android.hms.unity.activity.NativeBridgeActivity;

public class GenericBridge {

    private static final String TAG = GenericBridge.class.getSimpleName();

    private static final int CODE = BridgeType.GENERIC;
    public static final String GENERIC = "GENERIC";

    private static Intent intent;
    private static GenericBridgeCallback callback;

    public static void receiveShow(final Intent intent, final GenericBridgeCallback callback) {
        Log.d(TAG, "[HMS] receiveShow");
        GenericBridge.intent = intent;
        GenericBridge.callback = callback;
        NativeBridgeActivity.start(GENERIC);
    }

    public static void launchShow(final NativeBridgeActivity activity) {
        Log.d(TAG, "[HMS] launchShow");
        activity.startActivityForResult(intent, CODE);
    }

    public static void returnShow(final Intent data) {
        Log.d(TAG, "[HMS] returnShow");
        callback.onSuccess(data);
    }
}
