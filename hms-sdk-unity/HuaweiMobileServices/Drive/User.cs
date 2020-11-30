using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class User : JavaObjectWrapper
    {
        //@Key
    private String category;
        //@Key
    private String displayName;
        //@Key
    private Boolean me;
        //@Key
    private String userAccount;
        //@Key
    private String permissionId;
       // @Key
    private String profilePhotoLink;

        public User(): base("com.huawei.cloud.services.drive.model")
        {
        }

        public String GetCategory()
        {
            return this.category;
        }

        public User SetCategory(String var1)
        {
            this.category = var1;
            return this;
        }

        public String GetDisplayName()
        {
            return this.displayName;
        }

        public User SetDisplayName(String var1)
        {
            this.displayName = var1;
            return this;
        }

        public Boolean GetMe()
        {
            return this.me;
        }

        public User SetMe(Boolean var1)
        {
            this.me = var1;
            return this;
        }

        public String GetUserAccount()
        {
            return this.userAccount;
        }

        public User SetUserAccount(String var1)
        {
            this.userAccount = var1;
            return this;
        }

        public String GetPermissionId()
        {
            return this.permissionId;
        }

        public User SetPermissionId(String var1)
        {
            this.permissionId = var1;
            return this;
        }

        public String GetProfilePhotoLink()
        {
            return this.profilePhotoLink;
        }

        public User SetProfilePhotoLink(String var1)
        {
            this.profilePhotoLink = var1;
            return this;
        }

        public User Set(String var1, AndroidJavaObject var2) => CallAsWrapper<User>("set");

        public User Clone() => CallAsWrapper<User>("clone");
    }
}
