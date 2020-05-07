namespace HuaweiMobileServices.Ads
{
    public interface IRewardAdLoadListener
    {
        void OnRewardAdFailedToLoad(int errorCode);
        void OnRewardedLoaded();
    }
}
