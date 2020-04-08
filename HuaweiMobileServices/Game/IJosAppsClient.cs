namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;

    public interface IJosAppsClient
    {
        void Init();

        ITask<string> AppId { get; }
    }
}