using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.IAP
{

    using UnityEngine;
    using HuaweiMobileServices.Utils;
    using HuaweiMobileServices.Base;

    public class IapApiException : HMSException
    {

        public IapApiException(AndroidJavaObject javaObject) : base(javaObject) { }

        public Status Status => JavaException.Call<AndroidJavaObject>("getStatus").AsWrapper<Status>();
    }

    public static class IapApiExceptionUtils
    {

        public static bool IsIapApiException(this HMSException exception) =>
            exception.JavaException.InstanceOf("com.huawei.hms.iap.IapApiException");

        public static IapApiException AsIapApiException(this HMSException exception) =>
            new IapApiException(exception.JavaException);

    }
}
