
namespace HuaweiMobileServices.Game
{
    using UnityEngine;

    public interface IAppUpdateClient
    {
        void CheckAppUpdate(ICheckUpdateCallback checkUpdateCallback);
        void ShowUpdateDialog(AndroidJavaObject apkUpgradeInfo, bool mustBtnOne);
        void ReleaseCallback();
    }
}