using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Id
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;
    using HuaweiMobileServices.Base;

    internal class HuaweiIdAuthServiceWrapper : JavaObjectWrapper, IHuaweiIdAuthService
    {
        public HuaweiIdAuthServiceWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidIntent SignInIntent => throw new NotImplementedException();

        public ITask<Void> CancelAuthorization() => 
            Call<AndroidJavaObject>("cancelAuthorization").AsWrapper<TaskVoidWrapper>();

        public ITask<Void> SignOut() =>
            Call<AndroidJavaObject>("signOut").AsWrapper<TaskVoidWrapper>();

        public ITask<AuthHuaweiId> SilentSignIn() => 
            Call<AndroidJavaObject>("silentSignIn").AsWrapper<TaskJavaObjectWrapper<AuthHuaweiId>>();
    }
}
