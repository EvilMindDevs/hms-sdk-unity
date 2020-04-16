package org.m0skit0.android.hms.unity.ads

interface RewardAdLoadListener {
    fun onRewardedLoaded()
    fun onRewardAdFailedToLoad(errorCode: Int)
}