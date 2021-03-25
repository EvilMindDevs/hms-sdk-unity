using UnityEngine;
using HuaweiMobileServices.Utils;
using System;
using HuaweiMobileServices.Nearby.Transfer;


public class DataCallback : JavaObjectWrapper
{

    private class DataCallbackInterface : AndroidJavaProxy
    {

        private readonly IDataCallback mListener;

        public DataCallbackInterface(IDataCallback listener) : base("org.m0skit0.android.hms.unity.nearby.DataListener")
        {
            mListener = listener;
        }

        public void OnReceived(string p0, AndroidJavaObject p1)
        {
            mListener.onReceived(p0, p1);
        }

        public void OnTransferUpdate(string p0, AndroidJavaObject p1)
        {
            mListener.onTransferUpdate(p0,p1);
        }

    }
    public DataCallback(IDataCallback listener)
        : base("org.m0skit0.android.hms.unity.nearby.DataListenerWrapper", new DataCallbackInterface(listener)) { }
 
}