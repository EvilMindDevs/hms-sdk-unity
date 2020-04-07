namespace com.huawei.hms.jos
{
    using HuaweiMobileServices.Base;

    public interface IJosAppsClient : IHuaweiApiInterface
    {
        void Init();

        Task<string> AppId { get; }
    }
}