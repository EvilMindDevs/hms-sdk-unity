namespace com.huawei.hms.jos
{
    using Activity = android.app.Activity;
    using ApkUpgradeInfo = com.huawei.updatesdk.service.appmgr.bean.ApkUpgradeInfo;
    using ICheckUpdateCallBack = com.huawei.updatesdk.service.otaupdate.ICheckUpdateCallBack;
    using Context = android.content.Context;
    using UpdateParams = com.huawei.updatesdk.service.otaupdate.UpdateParams;
    using UpdateSdkAPI = com.huawei.updatesdk.UpdateSdkAPI;

    // Wrapper for com.huawei.hms.jos.AppUpdateClientImpl
    public sealed class AppUpdateClientImpl : IAppUpdateClient
    {
        public AppUpdateClientImpl(Activity paramActivity)
        {
        }

        public AppUpdateClientImpl(Context paramContext)
        {
        }

        public void CheckAppUpdate(Context paramContext, ICheckUpdateCallBack paramCheckUpdateCallBack)
        {
            if (paramContext != null)
            {
                UpdateSdkAPI.checkAppUpdate(paramContext, (new UpdateParams.Builder()).setTargetPkgName(paramContext.PackageName).build(), paramCheckUpdateCallBack);
            }
        }

        public void ShowUpdateDialog(Context paramContext, ApkUpgradeInfo paramApkUpgradeInfo, bool paramBoolean)
        {
            UpdateSdkAPI.showUpdateDialog(paramContext, paramApkUpgradeInfo, paramBoolean);
        }

        public void ReleaseCallBack()
        {
            UpdateSdkAPI.releaseCallBack();
        }
    }

}