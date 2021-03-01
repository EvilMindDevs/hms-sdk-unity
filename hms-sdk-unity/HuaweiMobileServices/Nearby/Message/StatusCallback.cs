using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Message
{
   public class StatusCallback : JavaObjectWrapper
    {
         StatusCallback(AndroidJavaObject androidJavaObject  ) : base("org.m0skit0.android.hms.unity.nearby.DataListener")
        {
        }

    }
}
