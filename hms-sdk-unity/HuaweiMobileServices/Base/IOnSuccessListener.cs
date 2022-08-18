using HuaweiMobileServices.Utils;

namespace HuaweiMobileServices.Base
{

    public class OnSuccessListener<TResult> : JavaProxyWrapper
    {

        private readonly IOnSuccessListener<TResult> onSuccessListener;

        public OnSuccessListener(IOnSuccessListener<TResult> onSuccessListener) : base("com.huawei.hmf.tasks.OnSuccessListener")
        {
            this.onSuccessListener = onSuccessListener;
        }

        public void OnSuccess(TResult result)
        {
            onSuccessListener.onSuccess(result);
        }
    }

    public interface IOnSuccessListener<TResult>
    {
        void onSuccess(TResult var1);
    }

}
