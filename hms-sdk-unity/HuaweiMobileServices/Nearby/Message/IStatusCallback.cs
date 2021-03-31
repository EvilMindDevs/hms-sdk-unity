using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Nearby.Message
{
    public interface IStatusCallback
    {
        void onPermissionChanged(bool grantPermission);
    }
}
