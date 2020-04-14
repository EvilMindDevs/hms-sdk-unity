package org.m0skit0.android.hms.unity.base

import android.app.Activity
import android.content.Intent
import com.huawei.hms.support.api.client.Status
import org.m0skit0.android.hms.unity.TYPE
import org.m0skit0.android.hms.unity.activity.NativeBridgeActivity

class StatusWrapper {

    companion object {
        internal const val CODE = 0
        internal const val STATUS = "STATUS"

        @JvmStatic
        fun instance(): StatusWrapper = StatusWrapper()
    }

    fun startResolutionForResult(activity: Activity, status: Status) {
        Intent(activity, NativeBridgeActivity::class.java)
            .putExtra(TYPE, STATUS)
            .putExtra(STATUS, status)
            .let { intent ->
                activity.startActivity(intent)
            }
    }
}