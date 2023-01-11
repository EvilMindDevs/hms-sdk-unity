package org.m0skit0.android.hms.unity;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.util.Log;

import com.unity3d.player.UnityPlayer;
import com.unity3d.player.UnityPlayerActivity;

public class HMSUnityPlayerActivity extends UnityPlayerActivity {

    private static final String TAG = "HMSUnityPlayerActivity";

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        Log.d(TAG,"onActivityResult requestCode:"+requestCode + " resultCode:"+resultCode);

        if(requestCode == 1001)
        {
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
                case 108:
                    Log.i(TAG, "Result Code: " + resultCode + ": The user canceled the comment.)");
                    break;
                default:
                    Log.e(TAG, "Result Code: " + resultCode);
                    break;
            }
        }

    }
}
