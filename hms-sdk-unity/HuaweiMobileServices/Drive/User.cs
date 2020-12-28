using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class User : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public User(): base("com.huawei.cloud.services.drive.model"){}

        public String GetCategory() => Call<String>("getCategory");

        public User SetCategory(String var1) => CallAsWrapper<User>("setCategory", var1);

        public String GetDisplayName() => Call<String>("getDisplayName");

        public User SetDisplayName(String var1) => CallAsWrapper<User>("setDisplayName", var1);

        public Boolean GetMe() => Call<Boolean>("getMe");

        public User SetMe(Boolean var1) => CallAsWrapper<User>("setMe", var1);

        public String GetUserAccount() => Call<String>("getUserAccount");

        public User SetUserAccount(String var1) => CallAsWrapper<User>("setUserAccount", var1);

        public String GetPermissionId() => Call<String>("getPermissionId");

        public User SetPermissionId(String var1) => CallAsWrapper<User>("setPermissionId", var1);

        public String GetProfilePhotoLink() => Call<String>("ProfilePhotoLink");

        public User SetProfilePhotoLink(String var1) => CallAsWrapper<User>("setProfilePhotoLink", var1);

        public User Set(String var1, AndroidJavaObject var2) => CallAsWrapper<User>("set", var1, var2);

        public User Clone() => CallAsWrapper<User>("clone");
    }
}
