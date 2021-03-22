namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;

    public class StartIapActivityReq : JavaObjectWrapper
    {
        public static int TYPE_SUBSCRIBE_MANAGER_ACTIVITY = 2;

        public static int TYPE_SUBSCRIBE_EDIT_ACTIVITY = 3;

        public StartIapActivityReq() : base("com.huawei.hms.iap.entity.StartIapActivityReq") { }

        public virtual int Type
        {
            get => Call<int>("getType");
            set => Call("setType", value);
        }

        public virtual string SubscribeProductId
        {
            get => CallAsString("getSubscribeProductId");
            set => Call("setSubscribeProductId", value.AsJavaString());
        }
    }
}
