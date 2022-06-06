package org.m0skit0.android.hms.unity.inAppComment;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;

import com.unity3d.player.UnityPlayer;

public class InAppComment extends Activity {

    private static String TAG = "InAppComment";

    public static void showInAppComment() {

        try {
            Intent intent = new Intent("com.huawei.appmarket.intent.action.guidecomment");
            intent.setPackage("com.huawei.appmarket");
            UnityPlayer.currentActivity.startActivityForResult(intent, 1001);

        } catch (Exception e) {
            Log.d(TAG, "initInAppComment: " + e.getMessage());
        }
    }

    @Override
    protected void onCreate(Bundle bundle) {
        super.onCreate(bundle);
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        Log.d(TAG, "onActivityResult called");
        if (requestCode == 1001) {
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

}
