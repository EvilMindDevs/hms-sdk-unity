package org.m0skit0.android.hms.unity.scan.bridge;

import android.content.Intent;
import android.content.pm.PackageManager;
import android.os.Build;
import android.util.Log;

import com.huawei.hms.hmsscankit.ScanUtil;
import com.huawei.hms.ml.scan.HmsScan;
import com.huawei.hms.ml.scan.HmsScanAnalyzerOptions;

import org.m0skit0.android.hms.unity.BridgeType;
import org.m0skit0.android.hms.unity.activity.NativeBridgeActivity;

public class ScanKitBridge {

    private static final String TAG = ScanKitBridge.class.getSimpleName();
    private static final int CODE = BridgeType.SCAN;
    private static ScanBridgeCallback callback;
    public static final String SCAN = "SCAN";
    private static HmsScanAnalyzerOptions options;
    private static NativeBridgeActivity activity;

    public static void receiveShow(final ScanBridgeCallback callback, HmsScanAnalyzerOptions options) {
        Log.d(TAG, "[HMS] receiveShow");

        ScanKitBridge.callback = callback;
        ScanKitBridge.options = options;

        NativeBridgeActivity.start(SCAN);
    }

    public static void launchShow(final NativeBridgeActivity activity) {
        Log.d(TAG, "[HMS] launchShow");

        ScanUtil.startScan(activity, 1002, options);
    }

    public static void returnShow(final Intent data) {
        Log.d(TAG, "[HMS] returnShow");

        Object obj = data.getParcelableExtra(ScanUtil.RESULT);
        HmsScan hmsScan = (HmsScan) obj;
        String scanText = hmsScan.getOriginalValue();

        callback.onSuccess(scanText, hmsScan);
    }

    public static HmsScanAnalyzerOptions.Creator processCreator(HmsScanAnalyzerOptions.Creator creator, int var1) {
        return creator.setHmsScanTypes(var1);
    }

    public static void RequestForPermission(final NativeBridgeActivity activity) {

        boolean permissionCamera = activity.checkCallingOrSelfPermission("android.permission.CAMERA") == PackageManager.PERMISSION_GRANTED;

        if (!permissionCamera) {

            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M) {

                String[] permissions = {"android.permission.CAMERA"};

                activity.requestPermissions(
                        permissions,
                        BridgeType.SCAN);
            }
        } else {
            ScanUtil.startScan(activity, 1002, options);
        }
    }

}
