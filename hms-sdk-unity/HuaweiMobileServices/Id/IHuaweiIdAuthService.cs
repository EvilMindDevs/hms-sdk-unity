namespace HuaweiMobileServices.Id
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.support.hwid.service.HuaweiIdAuthService
    public interface IHuaweiIdAuthService
    {
        AndroidIntent SignInIntent { get; }

        ITask<AuthHuaweiId> SilentSignIn();

        ITask<Void> SignOut();

        ITask<Void> CancelAuthorization();
    }

}