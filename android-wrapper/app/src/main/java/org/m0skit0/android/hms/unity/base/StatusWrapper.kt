package org.m0skit0.android.hms.unity.base

import android.app.Activity
import com.huawei.hms.support.api.client.Status
import org.m0skit0.android.hms.unity.Wrapper

interface StatusWrapper : Wrapper {

    companion object {
        internal const val STATUS = "STATUS"
        fun instance(): StatusWrapper = StatusWrapperImpl()
    }

    fun startResolutionForResult(activity: Activity, status: Status)
}