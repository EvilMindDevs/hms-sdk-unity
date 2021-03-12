using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Message
{
    public class StatusCallback : JavaObjectWrapper
{
    private class StatusCallbackInterface : AndroidJavaProxy
    {
        private readonly IStatusCallback mListener;
        public StatusCallbackInterface(IStatusCallback listener) : base("org.m0skit0.android.hms.unity.nearby.StatusListener")
        {
            mListener = listener;
        }

        public void onPermissionChanged(bool grantPermission)
        {
            mListener.onPermissionChanged(grantPermission);
        }
    }
    public StatusCallback(IStatusCallback listener)
        : base("org.m0skit0.android.hms.unity.nearby.StatusListenerWrapper", new StatusCallbackInterface(listener)) { }
    }
}