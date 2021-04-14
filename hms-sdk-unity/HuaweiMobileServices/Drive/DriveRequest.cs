using System;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class DriveRequest<T> : AbstractJsonClientRequest<T>
    {

        
        public DriveRequest(AndroidJavaObject javaObject) : base(javaObject) { }

        public String GetFields() => Call<String>("getFields");

        public DriveRequest<T> SetFields(String var1) => CallAsWrapper<DriveRequest<T>>("setFields", var1);

        public String GetForm() => Call<String>("getForm");

        public DriveRequest<T> SetForm(String var1) => CallAsWrapper<DriveRequest<T>>("setForm", var1);

        public Boolean GetPrettyPrint() => Call<Boolean>("getPrettyPrint");

        public DriveRequest<T> SetPrettyPrint(Boolean var1) => CallAsWrapper<DriveRequest<T>>("setPrettyPrint", var1);

        public String GetQuotaId() => Call<String>("getQuotaId");

        public DriveRequest<T> SetQuotaId(String var1) => CallAsWrapper<DriveRequest<T>>("setQuotaId", var1);

        public Drive GetAbstractClient() => CallAsWrapper<Drive>("getAbstractClient");

        public DriveRequest<T> SetHeaders(AndroidJavaObject var1) => CallAsWrapper<DriveRequest<T>>("setHeaders", var1);

        public DriveRequest<T> SetDisableGZip(bool var1) => CallAsWrapper<DriveRequest<T>>("setDisableGZip", var1);

        public DriveRequest<T> Set(String var1, AndroidJavaObject var2) => CallAsWrapper<DriveRequest<T>>("set", var1, var2);

    }

}
