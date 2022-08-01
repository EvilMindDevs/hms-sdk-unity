namespace HuaweiMobileServices.Ads.InstallReferrer
{
    public interface IInstallReferrerStateCallback
    {
        void onInstallReferrerSetupFinished(int responseCode);
        void onInstallReferrerServiceDisconnected();
    }
}