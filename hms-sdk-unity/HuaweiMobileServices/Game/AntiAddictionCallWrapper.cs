using UnityEngine;

namespace HuaweiMobileServices.Game
{
    public class AntiAddictionCallWrapper : AndroidJavaProxy
    {
        private readonly IAntiAddictionCallback mListener;

        public AntiAddictionCallWrapper(IAntiAddictionCallback listener) : base("com.huawei.hms.jos.AntiAddictionCallback")
        {
            mListener = listener;
        }

        public void onExit()
        {
            mListener.OnExit();
        }
    }
}