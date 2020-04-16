package org.m0skit0.android.hms.unity.ads

class RewardAdLoadListenerWrapper(private val listener: RewardAdLoadListener) : com.huawei.hms.ads.reward.RewardAdLoadListener() {

    override fun onRewardedLoaded() {
        listener.onRewardedLoaded()
    }

    override fun onRewardAdFailedToLoad(errorCode: Int) {
        listener.onRewardAdFailedToLoad(errorCode)
    }
}