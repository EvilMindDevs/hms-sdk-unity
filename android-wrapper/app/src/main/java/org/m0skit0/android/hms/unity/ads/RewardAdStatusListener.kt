package org.m0skit0.android.hms.unity.ads

import com.huawei.hms.ads.reward.Reward

interface RewardAdStatusListener {
    fun onRewardAdClosed()
    fun onRewardAdFailedToShow(errorCode: Int)
    fun onRewardAdOpened()
    fun onRewarded(reward: Reward)
}