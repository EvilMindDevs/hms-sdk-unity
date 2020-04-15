package org.m0skit0.android.hms.unity.activity

import android.app.Activity
import android.content.Intent
import android.os.Bundle
import android.util.Log
import org.m0skit0.android.hms.unity.base.StatusBridge

internal const val TYPE = "TYPE"

class NativeBridgeActivity : Activity() {

    private val TAG = javaClass.simpleName

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        intent?.run {
            when (val type = getStringExtra(TYPE)) {
                StatusBridge.STATUS ->
                    StatusBridge.launchStartResolutionForResult(this@NativeBridgeActivity)
                else -> Log.e(TAG, "Unknown type $type")
            }
        }
    }

    override fun onActivityResult(requestCode: Int, resultCode: Int, data: Intent?) {
        super.onActivityResult(requestCode, resultCode, data)
        when (requestCode) {
            StatusBridge.CODE -> StatusBridge.returnStartResolutionForResult()
        }
        finish()
    }
}
