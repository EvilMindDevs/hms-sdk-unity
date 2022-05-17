namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;

    public interface IJosAppsClient
    {
        ITask<Void> Init(AppParams appParams);

        ITask<string> AppId { get; }
    }
}