package org.m0skit0.android.hms.unity.inAppComment;

import android.content.Intent;
import android.util.Log;

import org.m0skit0.android.hms.unity.activity.NativeBridgeActivity;

public class InAppCommentBridge {

    public static final String IN_APP_COMMENT = "IN_APP_COMMENT";
    private static final String TAG = InAppCommentBridge.class.getSimpleName();

    private static Intent intent;
    private static int currentRequestCode;

    public static void receiveShow(final Intent currentIntent, int requestCode) {
        Log.d(TAG, "[HMS] receiveShow");
        intent = currentIntent;
        currentRequestCode = requestCode;
        NativeBridgeActivity.start(IN_APP_COMMENT);
    }

    public static void launchShow(final NativeBridgeActivity activity) {
        Log.d(TAG, "[HMS] launchShow");
        activity.startActivityForResult(intent, currentRequestCode);
    }

    public static void returnShow(int requestCode, int resultCode) {
        Log.d(TAG, "[HMS] returnShow");
        if (requestCode == InAppComment.REQUEST_CODE) {
            InAppComment.checkResult(resultCode);
        } else {
            Log.e(TAG, "No return match for request code : " + requestCode);
        }
    }
}
