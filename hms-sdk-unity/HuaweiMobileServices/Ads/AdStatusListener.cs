using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Ads
{
    public class AdLoadErrorCodeEventArgs : EventArgs
    {
        public int ErrorCode { get; set; }
    }

    public class AdStatusListener : AndroidJavaProxy
    {
        public event EventHandler<EventArgs> mOnAdClosed;

        public event EventHandler<AdLoadErrorCodeEventArgs> mOnAdFailed;

        public event EventHandler<EventArgs> mOnAdLeftApp;

        public event EventHandler<EventArgs> mOnAdOpened;

        public event EventHandler<EventArgs> mOnAdLoaded;

        public event EventHandler<EventArgs> mOnAdClicked;

        public event EventHandler<EventArgs> mOnAdImpression;

        public AdStatusListener() : base("org.m0skit0.android.hms.unity.ads.AdListener") { }

        public void onAdClosed()
        {
            if (mOnAdClosed != null)
            {
                this.CallOnMainThread(() => { mOnAdClosed(this, EventArgs.Empty); });
            }
        }

        public void onAdFailed(int errorCode)
        {
            if (mOnAdFailed != null)
            {
                AdLoadErrorCodeEventArgs args = new AdLoadErrorCodeEventArgs()
                {
                    ErrorCode = errorCode
                };
                this.CallOnMainThread(() => { mOnAdFailed(this, args); });
            }
        }

        public void onAdLeave()
        {
            if (mOnAdLeftApp != null)
            {
                this.CallOnMainThread(() => { mOnAdLeftApp(this, EventArgs.Empty); });
            }
        }

        public void onAdOpened()
        {
            if (mOnAdOpened != null)
            {
                this.CallOnMainThread(() => { mOnAdOpened(this, EventArgs.Empty); });
            }
        }

        public void onAdLoaded()
        {
            if (mOnAdLoaded != null)
            {
                this.CallOnMainThread(() => { mOnAdLoaded(this, EventArgs.Empty); });
            }
        }

        public void onAdClicked()
        {
            if (mOnAdClicked != null)
            {
                this.CallOnMainThread(() => { mOnAdClicked(this, EventArgs.Empty); });
            }
        }

        public void onAdImpression()
        {
            if (mOnAdImpression != null)
            {
                this.CallOnMainThread(() => { mOnAdImpression(this, EventArgs.Empty); });
            }
        }
    }
}
