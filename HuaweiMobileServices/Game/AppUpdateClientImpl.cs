namespace com.huawei.hms.jos
{
	using Activity = android.app.Activity;
	using Context = android.content.Context;
	using UpdateSdkAPI = com.huawei.updatesdk.UpdateSdkAPI;
	using ApkUpgradeInfo = com.huawei.updatesdk.service.appmgr.bean.ApkUpgradeInfo;
	using CheckUpdateCallBack = com.huawei.updatesdk.service.otaupdate.CheckUpdateCallBack;
	using UpdateParams = com.huawei.updatesdk.service.otaupdate.UpdateParams;

	public sealed class AppUpdateClientImpl : IAppUpdateClient
	{
	  public AppUpdateClientImpl(Activity paramActivity)
	  {
	  }

	  public AppUpdateClientImpl(Context paramContext)
	  {
	  }

	  public void CheckAppUpdate(Context paramContext, CheckUpdateCallBack paramCheckUpdateCallBack)
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