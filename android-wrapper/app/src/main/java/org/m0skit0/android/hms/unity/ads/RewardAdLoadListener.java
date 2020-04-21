package org.m0skit0.android.hms.unity.ads;

public interface RewardAdLoadListener {
    void onRewardedLoaded();
    void onRewardAdFailedToLoad(final int errorCode);
}
