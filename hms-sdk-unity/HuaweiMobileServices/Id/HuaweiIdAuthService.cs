using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Id
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;
    using HuaweiMobileServices.Base;

    public class HuaweiIdAuthService : JavaObjectWrapper
    {
        public HuaweiIdAuthService(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidIntent SignInIntent => CallAsWrapper<AndroidIntent>("signInIntent");

        public ITask<Void> CancelAuthorization() => CallAsWrapper<TaskVoidWrapper>("cancelAuthorization");

        public ITask<Void> SignOut() => CallAsWrapper<TaskVoidWrapper>("signOut");

        public ITask<AuthHuaweiId> SilentSignIn() => CallAsWrapper<TaskJavaObjectWrapper<AuthHuaweiId>>("silentSignIn");
    }
}
