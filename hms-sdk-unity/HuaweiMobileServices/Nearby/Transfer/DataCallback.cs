namespace HuaweiMobileServices.Nearby.Transfer
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;
    public class DataCallback : JavaObjectWrapper
    {

        private class DataCallbackInterface : AndroidJavaProxy
        {

            private readonly IDataCallback mListener;

            public DataCallbackInterface(IDataCallback listener) : base("org.m0skit0.android.hms.unity.nearby.DataListener")
            {
                mListener = listener;
            }

            public void onReceived(string p0, AndroidJavaObject p1)
            {
                this.CallOnMainThread(() => { mListener.onReceived(p0, p1.AsWrapper<Data>()); });
            }

            public void onTransferUpdate(string p0, AndroidJavaObject p1)
            {
                this.CallOnMainThread(() => { mListener.onTransferUpdate(p0, p1.AsWrapper<TransferStateUpdate>()); });
            }

        }
        public DataCallback(IDataCallback listener)
            : base("org.m0skit0.android.hms.unity.nearby.DataListenerWrapper", new DataCallbackInterface(listener)) { }

    }
}
