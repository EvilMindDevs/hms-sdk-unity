package org.m0skit0.android.hms.unity.ads;

import com.huawei.hms.ads.reward.Reward;

public interface RewardAdStatusListener {
    void onRewardAdClosed();
    void onRewardAdFailedToShow(final int errorCode);
    void onRewardAdOpened();
    void onRewarded(final Reward reward);
}
