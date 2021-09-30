﻿namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.iap.entity.PurchaseResultInfo
    public class PurchaseResultInfo : JavaObjectWrapper
    {
        
        public PurchaseResultInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual int ReturnCode => Call<int>("getReturnCode");

        public virtual string ErrMsg => CallAsString("getErrMsg");

        public virtual InAppPurchaseData InAppPurchaseData => new InAppPurchaseData(CallAsString("getInAppPurchaseData"));

        public virtual string InAppPurchaseDataRawJSON => CallAsString("getInAppPurchaseData");

        public virtual string InAppDataSignature => CallAsString("getInAppDataSignature");

    }

}
