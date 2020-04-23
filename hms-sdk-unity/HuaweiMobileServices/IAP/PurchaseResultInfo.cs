﻿namespace HuaweiMobileServices.IAP
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.iap.entity.PurchaseResultInfo
    public class PurchaseResultInfo : JavaObjectWrapper
    {

        public PurchaseResultInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual int ReturnCode => Call<int>("getReturnCode");

        public virtual string ErrMsg => CallAsString("getErrMsg");

        public virtual string InAppPurchaseData => CallAsString("getInAppPurchaseData");

        public virtual string InAppDataSignature => CallAsString("getInAppDataSignature");

    }

}