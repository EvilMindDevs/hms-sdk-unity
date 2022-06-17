using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class AccessMethodWrapper : AndroidJavaProxy
    {

        private readonly Func<String> mListener;

        public AccessMethodWrapper(Func<String> listener) : base("com.huawei.cloud.base.auth.DriveCredential$AccessMethod")
        {
            mListener = listener;
        }

        public String RefreshToken() => mListener();

    }
}
