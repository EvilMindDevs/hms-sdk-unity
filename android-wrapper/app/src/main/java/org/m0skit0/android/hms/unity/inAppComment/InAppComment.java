package org.m0skit0.android.hms.unity.inAppComment;

import android.content.Intent;
import android.util.Log;

import com.unity3d.player.UnityPlayer;

import org.m0skit0.android.hms.unity.activity.NativeBridgeActivity;

public class InAppComment extends InAppCommentBridge {

    public static final int REQUEST_CODE = 1001;
    private static final String TAG = InAppComment.class.getSimpleName();

    public static void showInAppComment() {
        Log.d(TAG, "showInAppComment called");
        try {
            final Intent intent = new Intent(UnityPlayer.currentActivity, NativeBridgeActivity.class);
            intent.setAction("com.huawei.appmarket.intent.action.guidecomment");
            intent.setPackage("com.huawei.appmarket");
            receiveShow(intent, REQUEST_CODE);
        } catch (Exception e) {
            Log.d(TAG, "Exception on showInAppComment: " + e.getMessage());
        }
    }

    public static void checkResult(int resultCode) {
        Log.d(TAG, "[HMS] returnShow");
        switch (resultCode) {
            case 101:
                Log.e(TAG, "Result Code: " + resultCode + ": The app has not been released on AppGallery.");
                break;
            case 104:
                Log.e(TAG, "Result Code: " + resultCode + ": The HUAWEI ID sign-in status is invalid.");
                break;
            case 105:
                Log.e(TAG, "Result Code: " + resultCode + ": The user does not meet the conditions for displaying the comment pop-up.");
                break;
            case 106:
                Log.e(TAG, "Result Code: " + resultCode + ": The commenting function is disabled.");
                break;
            case 107:
                Log.e(TAG, "Result Code: " + resultCode + ": The in-app commenting service is not supported. (Apps released in the Chinese mainland do not support this service.)");
                break;
            default:
                Log.e(TAG, "Result Code: " + resultCode);
                break;
        }
    }

}
