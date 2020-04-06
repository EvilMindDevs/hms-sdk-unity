using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{

    public class OwnedPurchasesResult : JavaObjectWrapperByConstructor
    {

        internal OwnedPurchasesResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual int ReturnCode
        {
            get => mJavaObject.Call<int>("getReturnCode");
        }


        public virtual string ErrMsg
        {
            get => mJavaObject.Call<AndroidJavaObject>("getErrMsg").AsString();
        }


        public virtual string ContinuationToken
        {
            get => mJavaObject.Call<AndroidJavaObject>("getContinuationToken").AsString();
        }


        public virtual IList<string> ItemList
        {
            get => mJavaObject.Call<AndroidJavaObject>("getItemList").AsStringList();
        }


        public virtual IList<string> InAppSignature
        {
            get => mJavaObject.Call<AndroidJavaObject>("getInAppSignature").AsStringList();
        }


        public virtual IList<string> InAppPurchaseDataList
        {
            get => mJavaObject.Call<AndroidJavaObject>("getInAppPurchaseDataList").AsStringList();
        }


        public virtual IList<string> PlacedInappPurchaseDataList
        {
            get => mJavaObject.Call<AndroidJavaObject>("getPlacedInappPurchaseDataList").AsStringList();
        }


        public virtual IList<string> PlacedInappSignatureList
        {
            get => mJavaObject.Call<AndroidJavaObject>("getPlacedInappSignatureList").AsStringList();
        }

    }

}