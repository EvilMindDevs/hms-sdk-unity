package org.m0skit0.android.hms.unity.ads

class OnMetadataChangedListenerWrapper(private val listener: OnMetadataChangedListener) : com.huawei.hms.ads.reward.OnMetadataChangedListener() {

    override fun onMetadataChanged() {
        listener.onMetadataChanged()
    }
}
