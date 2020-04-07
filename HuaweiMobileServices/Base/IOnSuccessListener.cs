namespace HuaweiMobileServices.Base
{
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hmf.tasks.OnSuccessListener
    public interface IOnSuccessListener<T> where T : JavaObjectWrapper
    {
        void OnSuccess(T result);
    }

}