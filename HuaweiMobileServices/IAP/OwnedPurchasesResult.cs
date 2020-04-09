namespace HuaweiMobileServices.IAP
{

    using HuaweiMobileServices.Utils;
    using System.Collections.Generic;
    using UnityEngine;

    public class OwnedPurchasesResult : JavaObjectWrapper
    {

        public OwnedPurchasesResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual int ReturnCode
        {
            get => Call<int>("getReturnCode");
        }


        public virtual string ErrMsg
        {
            get => Call<AndroidJavaObject>("getErrMsg").AsString();
        }


        public virtual string ContinuationToken
        {
            get => Call<AndroidJavaObject>("getContinuationToken").AsString();
        }


        public virtual IList<string> ItemList
        {
            get => Call<AndroidJavaObject>("getItemList").AsStringList();
        }


        public virtual IList<string> InAppSignature
        {
            get => Call<AndroidJavaObject>("getInAppSignature").AsStringList();
        }


        public virtual IList<string> InAppPurchaseDataList
        {
            get => Call<AndroidJavaObject>("getInAppPurchaseDataList").AsStringList();
        }


        public virtual IList<string> PlacedInappPurchaseDataList
        {
            get => Call<AndroidJavaObject>("getPlacedInappPurchaseDataList").AsStringList();
        }


        public virtual IList<string> PlacedInappSignatureList
        {
            get => Call<AndroidJavaObject>("getPlacedInappSignatureList").AsStringList();
        }

    }

}