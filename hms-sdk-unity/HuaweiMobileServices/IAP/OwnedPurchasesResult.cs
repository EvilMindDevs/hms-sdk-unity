namespace HuaweiMobileServices.IAP
{

    using HuaweiMobileServices.Utils;
    using System.Collections.Generic;
    using UnityEngine;

    public class OwnedPurchasesResult : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public OwnedPurchasesResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual int ReturnCode => Call<int>("getReturnCode");

        public virtual string ErrMsg => CallAsString("getErrMsg");

        public virtual string ContinuationToken => CallAsString("getContinuationToken");

        public virtual IList<string> ItemList => Call<AndroidJavaObject>("getItemList").AsStringList();

        public virtual IList<string> InAppSignature => Call<AndroidJavaObject>("getInAppSignature").AsStringList();

        public virtual IList<string> InAppPurchaseDataList => Call<AndroidJavaObject>("getInAppPurchaseDataList").AsStringList();

        public virtual IList<string> PlacedInappPurchaseDataList =>
            Call<AndroidJavaObject>("getPlacedInappPurchaseDataList").AsStringList();

        public virtual IList<string> PlacedInappSignatureList =>
            Call<AndroidJavaObject>("getPlacedInappSignatureList").AsStringList();

    }

}