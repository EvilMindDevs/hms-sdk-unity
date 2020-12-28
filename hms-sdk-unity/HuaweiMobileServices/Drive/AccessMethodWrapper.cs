using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    internal class AccessMethodWrapper : AndroidJavaProxy
    {

        private readonly Func<String> mListener;

        internal AccessMethodWrapper(Func<String> listener) : base("com.huawei.cloud.base.auth.DriveCredential$AccessMethod")
        {
            mListener = listener;
        }

        public String RefreshToken() => mListener();

    }
}
