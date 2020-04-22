namespace HuaweiMobileServices.IAP
{
    public class OrderStatusCode
    {
        public const int ORDER_STATE_SUCCESS = 0;

        public const int ORDER_STATE_FAILED = -1;

        public const int ORDER_STATE_CANCEL = 60000;

        public const int ORDER_STATE_PARAM_ERROR = 60001;

        public const int ORDER_STATE_NET_ERROR = 60005;

        public const int ORDER_VR_UNINSTALL_ERROR = 60020;

        public const int ORDER_HWID_NOT_LOGIN = 60050;

        public const int ORDER_PRODUCT_OWNED = 60051;

        public const int ORDER_PRODUCT_NOT_OWNED = 60052;

        public const int ORDER_PRODUCT_CONSUMED = 60053;

        public const int ORDER_ACCOUNT_AREA_NOT_SUPPORTED = 60054;

        public const int ORDER_NOT_ACCEPT_AGREEMENT = 60055;
    }

}