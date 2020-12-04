using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class User : JavaObjectWrapper
    {
     
        public User(): base("com.huawei.cloud.services.drive.model")
        {
        }

        public String GetCategory()
        {
            return Call<String>("getCategory");
        }

        public User SetCategory(String var1)
        {
            return CallAsWrapper<User>("setCategory", var1);
        }

        public String GetDisplayName()
        {
            return Call<String>("getDisplayName");
        }

        public User SetDisplayName(String var1)
        {
            return CallAsWrapper<User>("setDisplayName", var1);

        }

        public Boolean GetMe()
        {
            return Call<Boolean>("getMe");
        }

        public User SetMe(Boolean var1)
        {
            return CallAsWrapper<User>("setMe", var1);
        }

        public String GetUserAccount()
        {
            return Call<String>("getUserAccount");
        }

        public User SetUserAccount(String var1)
        {
            return CallAsWrapper<User>("setUserAccount", var1);
        }

        public String GetPermissionId()
        {
            return Call<String>("getPermissionId");
        }

        public User SetPermissionId(String var1)
        {
            return CallAsWrapper<User>("setPermissionId", var1);
        }

        public String GetProfilePhotoLink()
        {
            return Call<String>("ProfilePhotoLink");
        }

        public User SetProfilePhotoLink(String var1)
        {
            return CallAsWrapper<User>("setProfilePhotoLink", var1);
        }

        public User Set(String var1, AndroidJavaObject var2) => CallAsWrapper<User>("set", var1, var2);

        public User Clone() => CallAsWrapper<User>("clone");
    }
}
