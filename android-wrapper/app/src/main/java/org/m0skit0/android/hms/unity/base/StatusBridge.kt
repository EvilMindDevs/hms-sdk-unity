package org.m0skit0.android.hms.unity.base

import android.content.Intent
import com.huawei.hms.support.api.client.Status
import com.unity3d.player.UnityPlayer
import org.m0skit0.android.hms.unity.activity.NativeBridgeActivity
import org.m0skit0.android.hms.unity.activity.TYPE

data class StatusBridgeData(
    internal val gameObject: String,
    internal val gameObjectMethod: String,
    internal val status: Status
)

object StatusBridge {

    internal const val CODE = 0
    internal const val STATUS = "STATUS"

    private lateinit var statusBridgeData: StatusBridgeData

    @JvmStatic
    fun receiveStartResolutionForResult(data: StatusBridgeData) {
        statusBridgeData = data
        Intent(UnityPlayer.currentActivity, NativeBridgeActivity::class.java)
            .putExtra(TYPE, STATUS)
            .let { intent ->
                UnityPlayer.currentActivity.startActivity(intent)
            }
    }

    fun launchStartResolutionForResult(activity: NativeBridgeActivity) {
        statusBridgeData.status.startResolutionForResult(activity, CODE)
    }

    fun returnStartResolutionForResult() {
        UnityPlayer.UnitySendMessage(statusBridgeData.gameObject, statusBridgeData.gameObjectMethod, "")
    }
}
