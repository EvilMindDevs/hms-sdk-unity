using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Id
{
    public class ReadSmsConstant
    {
        public static readonly String READ_SMS_BROADCAST_ACTION = "com.huawei.hms.auth.api.phone.SMS_RETRIEVED";
        public static readonly String EXTRA_SMS_MESSAGE = "com.huawei.hms.auth.api.phone.EXTRA_SMS_MESSAGE";
        public static readonly String EXTRA_STATUS = "com.huawei.hms.auth.api.phone.EXTRA_STATUS";
        public static readonly int FAIL = 2022;
        public static readonly int TIMEOUT = 15;
        public static readonly int SUCCESS = 0;
    }
}
