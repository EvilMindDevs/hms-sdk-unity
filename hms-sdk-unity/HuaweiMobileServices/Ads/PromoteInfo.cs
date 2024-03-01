using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Ads
{
    //https://developer.huawei.com/consumer/en/doc/HMSCore-References/promoteinfo-0000001750234640
    //https://developer.huawei.com/consumer/en/doc/HMSCore-References/nativead-0000001133473814#section6726104634610
    // Wrapper for com.huawei.hms.ads.base.PromoteInfo
    // com.huawei.openalliance.ad.beans.metadata.PromoteInfo
    public class PromoteInfo : JavaObjectWrapper
    {
        public PromoteInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        /*Promotion subtype.
          1-  Quick app.
          2-  WeChat mini-program.
        */
        public int Type => Call<int>("getType");

        public string Name => Call<string>("getName");
    }
}
