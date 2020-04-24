package org.m0skit0.android.hms.unity.ads;

import com.huawei.hms.ads.reward.Reward;

public class RewardAdStatusListenerWrapper extends com.huawei.hms.ads.reward.RewardAdStatusListener {

    private final RewardAdStatusListener listener;

    public RewardAdStatusListenerWrapper(final RewardAdStatusListener listener) {
        super();
        this.listener = listener;
    }

    @Override
    public void onRewardAdClosed() {
        super.onRewardAdClosed();
        listener.onRewardAdClosed();
    }

    @Override
    public void onRewardAdFailedToShow(int errorCode) {
        super.onRewardAdFailedToShow(errorCode);
        listener.onRewardAdFailedToShow(errorCode);
    }

    @Override
    public void onRewardAdOpened() {
        super.onRewardAdOpened();
        listener.onRewardAdOpened();
    }

    @Override
    public void onRewarded(Reward reward) {
        super.onRewarded(reward);
        listener.onRewarded(reward);
    }
}
