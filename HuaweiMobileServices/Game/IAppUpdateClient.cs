namespace com.huawei.hms.jos
{
    using ApkUpgradeInfo = com.huawei.updatesdk.service.appmgr.bean.ApkUpgradeInfo;
    using CheckUpdateCallBack = com.huawei.updatesdk.service.otaupdate.CheckUpdateCallBack;
    using Context = android.content.Context;

    public interface IAppUpdateClient
    {
        void CheckAppUpdate(Context paramContext, CheckUpdateCallBack paramCheckUpdateCallBack);

        void ShowUpdateDialog(Context paramContext, ApkUpgradeInfo paramApkUpgradeInfo, bool paramBoolean);

        void ReleaseCallBack();
    }

}