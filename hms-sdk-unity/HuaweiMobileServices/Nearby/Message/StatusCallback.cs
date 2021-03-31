using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Message
{
    public class StatusCallback : AndroidJavaProxy
    {
        private Action<bool> OnPermissionChanged;

        public StatusCallback(Action<bool> onPermissionChanged) : base("com.huawei.hms.nearby.message.StatusCallback")
        {
            OnPermissionChanged = onPermissionChanged;
        }
        public void onPermissionChanged(bool grantPermission)
        {
            OnPermissionChanged.Invoke(grantPermission);
        }
    }
}
