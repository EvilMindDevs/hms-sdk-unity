using HuaweiMobileServices.Base;

namespace HuaweiMobileServices.AppLinking
{
    public interface IReferrerProvider
    {
        ITask<string> GetCustomReferrer();
    }
}
