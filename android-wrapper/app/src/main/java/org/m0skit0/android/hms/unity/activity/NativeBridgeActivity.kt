package org.m0skit0.android.hms.unity.activity

import android.app.Activity
import android.content.Intent
import android.os.Bundle
import android.util.Log
import com.huawei.hms.support.api.client.Status
import com.unity3d.player.UnityPlayer
import org.m0skit0.android.hms.unity.TYPE
import org.m0skit0.android.hms.unity.WrapperTypes
import org.m0skit0.android.hms.unity.base.StatusWrapper

class NativeBridgeActivity : Activity() {

    private val TAG = javaClass.simpleName

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        intent?.run {
            when (val type = getStringExtra(TYPE)) {
                StatusWrapper.STATUS -> startResolutionForResult()
                else -> Log.e(TAG, "Unknown type $type")
            }
        }
    }

    override fun onActivityResult(requestCode: Int, resultCode: Int, data: Intent?) {
        super.onActivityResult(requestCode, resultCode, data)
        when (requestCode) {
            WrapperTypes.STATUS.code -> UnityPlayer.UnitySendMessage("gameObject?", "gameObjectMethod?", "null")
        }
    }

    private fun startResolutionForResult() {
        val status: Status = intent.getParcelableExtra(StatusWrapper.STATUS)!!
        status.startResolutionForResult(this, WrapperTypes.STATUS.code);
    }
}
