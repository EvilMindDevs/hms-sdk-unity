package org.m0skit0.android.hms.unity

import android.content.Intent

interface GenericBridgeCallback {
    fun onSuccess(data: Intent)
    fun onFailure(error: Exception)
}