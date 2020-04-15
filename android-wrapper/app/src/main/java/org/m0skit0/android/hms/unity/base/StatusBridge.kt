package org.m0skit0.android.hms.unity.base

import android.content.Intent
import com.huawei.hms.support.api.client.Status
import com.unity3d.player.UnityPlayer
import org.m0skit0.android.hms.unity.BridgeCallback
import org.m0skit0.android.hms.unity.activity.NativeBridgeActivity
import org.m0skit0.android.hms.unity.activity.TYPE

object StatusBridge {

    internal const val CODE = 0
    internal const val STATUS = "STATUS"

    private lateinit var status: Status
    private lateinit var callback: BridgeCallback

    @JvmStatic
    fun receiveStartResolutionForResult(status: Status, callback: BridgeCallback) {
        this.status = status
        this.callback = callback
        Intent(UnityPlayer.currentActivity, NativeBridgeActivity::class.java)
            .putExtra(TYPE, STATUS)
            .let { intent ->
                UnityPlayer.currentActivity.startActivity(intent)
            }
    }

    fun launchStartResolutionForResult(activity: NativeBridgeActivity) {
        status.startResolutionForResult(activity, CODE)
    }

    fun returnStartResolutionForResult() {
        callback.onCallback()
    }
}
