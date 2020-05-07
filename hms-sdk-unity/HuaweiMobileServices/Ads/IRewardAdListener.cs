namespace HuaweiMobileServices.Ads
{

    // Wrapper for com.huawei.hms.ads.reward.RewardAdListener
    public interface IRewardAdListener
    {
        void OnRewarded(Reward reward);

        void OnRewardAdClosed();

        void OnRewardAdFailedToLoad(int errorCode);

        void OnRewardAdLeftApp();

        void OnRewardAdLoaded();

        void OnRewardAdOpened();

        void OnRewardAdCompleted();

        void OnRewardAdStarted();
    }

}