namespace HuaweiMobileServices.Base
{
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hmf.tasks.OnSuccessListener
    public interface IOnSuccessListener<T>
    {
        void OnSuccess(T result);
    }

}