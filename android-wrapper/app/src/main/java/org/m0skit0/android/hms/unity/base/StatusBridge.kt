package org.m0skit0.android.hms.unity.base

import android.content.Intent
import com.huawei.hms.support.api.client.Status
import org.m0skit0.android.hms.unity.GenericBridgeCallback
import org.m0skit0.android.hms.unity.activity.NativeBridgeActivity
import kotlin.random.Random

object StatusBridge {

    internal val CODE = Random.Default.nextInt()
    internal const val STATUS = "STATUS"

    private lateinit var status: Status
    private lateinit var callback: GenericBridgeCallback

    @JvmStatic
    fun receiveStartResolutionForResult(status: Status, callback: GenericBridgeCallback) {
        this.status = status
        this.callback = callback
        NativeBridgeActivity.start()
    }

    fun launchStartResolutionForResult(activity: NativeBridgeActivity) {
        status.startResolutionForResult(activity, CODE)
    }

    fun returnStartResolutionForResult(data: Intent) {
        callback.onSuccess(data)
    }
}
