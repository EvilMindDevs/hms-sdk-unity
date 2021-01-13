package org.m0skit0.android.hms.unity.activity;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;

import com.huawei.hmf.tasks.OnFailureListener;
import com.huawei.hmf.tasks.OnSuccessListener;
import com.huawei.hmf.tasks.Task;
import com.huawei.hms.common.ApiException;
import com.huawei.hms.jos.games.Games;
import com.huawei.hms.jos.games.archive.ArchiveConstants;
import com.huawei.hms.jos.games.archive.ArchiveSummary;

public class StartActivity extends Activity {
    private String TAG = "Plug.StartActivity";
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        Log.d(TAG,"Activity created");
    }
    public void Call(Intent intent)
    {
        // Creating an intent with the current activity and the activity we wish to start
        startActivityForResult(intent,1);
    }
    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
         super.onActivityResult(requestCode, resultCode, data);
        if (requestCode == 1) {
            Log.d(TAG,"Activity onActivityResult");
            if (data == null) {
                return;
            }

        }
    }
}