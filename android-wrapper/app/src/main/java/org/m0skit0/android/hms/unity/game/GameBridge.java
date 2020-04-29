package org.m0skit0.android.hms.unity.game;

import android.content.Intent;
import android.util.Log;

import org.m0skit0.android.hms.unity.BridgeType;
import org.m0skit0.android.hms.unity.GenericBridgeCallback;
import org.m0skit0.android.hms.unity.activity.NativeBridgeActivity;

public class GameBridge {

    private static final String TAG = GameBridge.class.getSimpleName();

    public static final int CODE = BridgeType.GAME;
    public static final String GAME = "GAME";

    private static Intent intent;
    private static GenericBridgeCallback callback;

    public static void receiveShowAchievementList(final Intent intent, final GenericBridgeCallback callback) {
        Log.d(TAG, "[HMS] receiveShowAchievementList");
        GameBridge.intent = intent;
        GameBridge.callback = callback;
        NativeBridgeActivity.start(GAME);
    }

    public static void launchShowAchievementList(final NativeBridgeActivity activity) {
        Log.d(TAG, "[HMS] launchShowAchievementList");
        activity.startActivityForResult(intent, CODE);
    }

    public static void returnShowAchievementList(final Intent data) {
        Log.d(TAG, "[HMS] returnShowAchievementList");
        callback.onSuccess(data);
    }
}
