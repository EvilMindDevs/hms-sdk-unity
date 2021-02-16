using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.AuthService
{
    public interface OnVerifyCodeCallBack
    {
        void onVerifySuccess(string paramString1, string paramString2);
        void onVerifyFailure(Exception exception);
    }
}
