namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class CheckUpdateCallbackWrapper : AndroidJavaProxy
    {
        private readonly ICheckUpdateCallback mListener;

        public CheckUpdateCallbackWrapper(ICheckUpdateCallback listener) : base("com.huawei.updatesdk.service.otaupdate.CheckUpdateCallBack")
        {
            mListener = listener;
        }

        public void onUpdateInfo(AndroidJavaObject intent)
        {
            mListener.OnUpdateInfo(intent.AsWrapper<AndroidIntent>());
        }

        public void onMarketInstallInfo(AndroidJavaObject intent)
        {
            mListener.OnMarketInstallInfo(intent.AsWrapper<AndroidIntent>());
        }

        public void onMarketStoreError(int responseCode)
        {
            mListener.OnMarketStoreError(responseCode);
        }

        public void onUpdateStoreError(int responseCode)
        {
            mListener.OnUpdateStoreError(responseCode);
        }
    }
}