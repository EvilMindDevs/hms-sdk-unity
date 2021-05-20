using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Id
{
    //com.huawei.hms.support.hwid
    public class AccountAuthResult : JavaObjectWrapper
    {
        
        public AccountAuthResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public AuthAccount AuthResult => CallAsWrapper<AuthAccount>("getAuthResult");

        public void SetAuthAccount(AuthAccount authAccount) => Call("getAuthResult", authAccount);
        public bool Success => Call<bool>("isSuccess");

    }
}
