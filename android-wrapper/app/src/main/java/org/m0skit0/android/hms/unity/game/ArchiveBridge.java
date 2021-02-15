package org.m0skit0.android.hms.unity.game;

import android.content.Intent;
import android.util.Log;

import org.m0skit0.android.hms.unity.BridgeType;
import org.m0skit0.android.hms.unity.GenericBridgeCallback;
import org.m0skit0.android.hms.unity.activity.NativeBridgeActivity;

public class ArchiveBridge {

    private static final String TAG = ArchiveBridge.class.getSimpleName();
    private static final int CODE = BridgeType.ARCHIVE;
    private static GenericBridgeCallback callback;
    public static final String SAVED = "SAVED";

    private static Intent intent;

    public static void receiveShow(final Intent intent, final GenericBridgeCallback callback) {
        Log.d(TAG, "[HMS] receiveShow");
        ArchiveBridge.intent = intent;
        ArchiveBridge.callback = callback;
        NativeBridgeActivity.start(SAVED);
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
