package org.m0skit0.android.hms.unity.base

import android.app.Activity
import android.content.Intent
import com.huawei.hms.support.api.client.Status
import org.m0skit0.android.hms.unity.TYPE
import org.m0skit0.android.hms.unity.WrapperTypes
import org.m0skit0.android.hms.unity.activity.NativeBridgeActivity

internal class StatusWrapperImpl : StatusWrapper {

    override fun startResolutionForResult(activity: Activity, status: Status) {
        Intent(activity, NativeBridgeActivity::class.java)
            .putExtra(TYPE, WrapperTypes.STATUS.name)
            .putExtra(StatusWrapper.STATUS, status)
            .let { intent ->
                activity.startActivity(intent)
            }
    }
}