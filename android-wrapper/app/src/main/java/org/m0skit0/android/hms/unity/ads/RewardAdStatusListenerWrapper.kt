package org.m0skit0.android.hms.unity.ads

import com.huawei.hms.ads.reward.Reward

class RewardAdStatusListenerWrapper(private val listener: RewardAdStatusListener) : com.huawei.hms.ads.reward.RewardAdStatusListener() {

    override fun onRewardAdClosed() {
        listener.onRewardAdClosed()
    }

    override fun onRewardAdFailedToShow(errorCode: Int) {
        listener.onRewardAdFailedToShow(errorCode)
    }

    override fun onRewardAdOpened() {
        listener.onRewardAdOpened()
    }

    override fun onRewarded(reward: Reward) {
        listener.onRewarded(reward)
    }
}