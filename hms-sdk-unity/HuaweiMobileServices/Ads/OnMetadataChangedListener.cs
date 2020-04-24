using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Ads
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.ads.reward.OnMetadataChangedListener
    internal class OnMetadataChangedListener : JavaObjectWrapper
    {
        private class OnMetadataChangedListenerInterfaceWrapper : AndroidJavaProxy
        {

            private readonly IOnMetadataChangedListener mListener;

            public OnMetadataChangedListenerInterfaceWrapper(IOnMetadataChangedListener listener) : base("org.m0skit0.android.hms.unity.ads.OnMetadataChangedListener")
            {
                mListener = listener;
            }

            public void onMetadataChanged()
            {
                mListener.OnMetadataChanged();
            }
        }

        public OnMetadataChangedListener(IOnMetadataChangedListener listener) 
            : base("org.m0skit0.android.hms.unity.ads.OnMetadataChangedListenerWrapper", new OnMetadataChangedListenerInterfaceWrapper(listener)) { }
    }
}
