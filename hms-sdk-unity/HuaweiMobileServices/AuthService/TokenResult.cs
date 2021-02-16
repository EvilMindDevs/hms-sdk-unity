using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class TokenResult : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public TokenResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public string Token => Call<string>("getToken"); 

        public long ExpirePeriod => Call<long>("getExpirePeriod"); 
    }
}
