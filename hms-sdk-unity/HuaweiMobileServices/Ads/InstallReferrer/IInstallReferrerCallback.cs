namespace HuaweiMobileServices.Ads.InstallReferrer
{
    public interface IInstallReferrerCallback
    {
        void OnSuccess(string installReferrer, long clickTimestamp, long installTimestamp);
        void OnFail(string errMsg);
    }
}