package org.m0skit0.android.hms.unity.helper.FilePicker;

import android.content.Intent;
import android.graphics.Bitmap;

public interface FilePickerBridgeCallback {
    void onSuccess(final Intent intent, final Bitmap bitmap);
    void onFailure(final Exception exception);
}
