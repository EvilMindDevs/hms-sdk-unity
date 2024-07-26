package org.m0skit0.android.hms.unity.helper.FilePicker;

import android.content.Intent;
import android.content.pm.PackageManager;
import android.graphics.Bitmap;
import android.os.Build;
import android.util.Log;


import org.m0skit0.android.hms.unity.BridgeType;
import org.m0skit0.android.hms.unity.activity.NativeBridgeActivity;

public class FilePickerBridge {

    private static final String TAG = FilePickerBridge.class.getSimpleName();
    private static final int CODE = BridgeType.FILE_PICKER;
    private static FilePickerBridgeCallback callback;
    public static final String FILE_PICKER = "FILE_PICKER";

    private static NativeBridgeActivity activity;
    private static Intent intent;

    public static void receiveShow(final Intent intent, final FilePickerBridgeCallback callback) {
        Log.d(TAG, "[HMS] receiveShow");

        FilePickerBridge.callback = callback;
        FilePickerBridge.intent = intent;

        NativeBridgeActivity.start(FILE_PICKER);
    }

    public static void launchShow(final NativeBridgeActivity activity) {
        Log.d(TAG, "[HMS] launchShow");
        activity.startActivityForResult(intent, CODE);
    }

    public static void returnShow(final Intent data, Bitmap bitmap) {
        Log.d(TAG, "[HMS] returnShow");
        callback.onSuccess(data, bitmap);
    }

    public static void RequestForPermission(final NativeBridgeActivity activity) {

        boolean permissionAllFiles = activity.checkCallingOrSelfPermission("android.settings.MANAGE_APP_ALL_FILES_ACCESS_PERMISSION") == PackageManager.PERMISSION_GRANTED;

        if (!permissionAllFiles) {

            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M) {

                String[] permissions = {"android.settings.MANAGE_APP_ALL_FILES_ACCESS_PERMISSION"};

                activity.requestPermissions(
                        permissions,
                        BridgeType.FILE_PICKER);
            }
        }

        launchShow(activity);
    }
}
