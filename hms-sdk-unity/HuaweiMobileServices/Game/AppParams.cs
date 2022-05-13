using HuaweiMobileServices.Id;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Game
{
    public class AppParams : JavaObjectWrapper
    {
        private static readonly string CLASS_NAME = "com.huawei.hms.jos.AppParams";

        public AppParams(AndroidJavaObject javaObject) : base(javaObject) { }

        public AppParams(AccountAuthParams authScope) : base(CLASS_NAME, authScope.JavaObject) { }

        public AppParams(AccountAuthParams authScope, AntiAddictionCallWrapper antiAddictionCallback) : base(CLASS_NAME, authScope.JavaObject, antiAddictionCallback) { }

        public AccountAuthParams AuthScope
        {
            get => CallAsWrapper<AccountAuthParams>("getAuthScope");
            set => Call("setAuthScope", AuthScope.JavaObject);
        }

        public AntiAddictionCallWrapper AntiAddictionCallback
        {
            get => Call<AntiAddictionCallWrapper>("getAntiAddictionCallback");
            set => Call("setAntiAddictionCallback", AntiAddictionCallback);
        }
    }

    public interface IAntiAddictionCallback
    {
        void OnExit();
    }

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