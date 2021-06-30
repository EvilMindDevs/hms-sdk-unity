namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class EnvReadyResult : JavaObjectWrapper
    {

        public EnvReadyResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public int ReturnCode => Call<int>("getReturnCode");

        public int AccountFlag => Call<int>("getAccountFlag");

        public string CarrierId => CallAsString("getCarrierId");

        public string Country => CallAsString("getCountry");

    }
}
