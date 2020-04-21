package org.m0skit0.android.hms.unity.ads;

public class RewardAdLoadListenerWrapper extends com.huawei.hms.ads.reward.RewardAdLoadListener {

    private final RewardAdLoadListener listener;

    public RewardAdLoadListenerWrapper(final RewardAdLoadListener listener) {
        super();
        this.listener = listener;
    }

    @Override
    public void onRewardAdFailedToLoad(int errorCode) {
        super.onRewardAdFailedToLoad(errorCode);
        listener.onRewardAdFailedToLoad(errorCode);
    }

    @Override
    public void onRewardedLoaded() {
        super.onRewardedLoaded();
        listener.onRewardedLoaded();
    }
}
