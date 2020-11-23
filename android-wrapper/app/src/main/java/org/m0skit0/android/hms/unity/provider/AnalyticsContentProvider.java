package org.m0skit0.android.hms.unity.provider;

import android.content.ContentProvider;
import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.net.Uri;
import android.util.Log;

import com.huawei.agconnect.config.AGConnectServicesConfig;
import com.huawei.agconnect.config.LazyInputStream;
import com.huawei.hms.analytics.HiAnalytics;
import com.huawei.hms.analytics.HiAnalyticsInstance;
import com.huawei.hms.analytics.HiAnalyticsTools;

import java.io.IOException;
import java.io.InputStream;

public class AnalyticsContentProvider extends ContentProvider {

    private String TAG = AnalyticsContentProvider.class.getSimpleName();

    @Override
    public boolean onCreate() {

        Log.i(TAG, "AnalyticsContentProvider -> onCreate");
        AGConnectServicesConfig config = AGConnectServicesConfig.fromContext(this.getContext());
        config.overlayWith(new LazyInputStream(this.getContext()) {
            public InputStream get(Context context) {
                try {
                    //return context.openFileInput(AnalyticsContentProvider.class.getClassLoader().getResourceAsStream("xx").toString());
                    return context.getAssets().open("agconnect-services.json");
                } catch (IOException e) {
                    return null;
                }
            }
        });
        HiAnalyticsTools.enableLog();//analytic initialize
        HiAnalyticsInstance instance = HiAnalytics.getInstance(this.getContext());
         return false;
    }

    @Override
    public Cursor query(Uri uri, String[] projection, String selection, String[] selectionArgs, String sortOrder) {
        return null;
    }

    @Override
    public String getType(Uri uri) {
        return null;
    }

    @Override
    public Uri insert(Uri uri, ContentValues values) {
        return null;
    }

    @Override
    public int delete(Uri uri, String selection, String[] selectionArgs) {
        return 0;
    }

    @Override
    public int update(Uri uri, ContentValues values, String selection, String[] selectionArgs) {
        return 0;
    }

    @Override
    public void shutdown() {
        Log.i(TAG, "HMSContentProvider -> shutdown");
    }
}
