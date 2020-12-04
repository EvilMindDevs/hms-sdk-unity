using System;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class DriveRequest<T> : AbstractJsonClientRequest<T>
    {

        [UnityEngine.Scripting.Preserve]
        public DriveRequest(AndroidJavaObject javaObject) : base(javaObject) { }

        public String GetFields()
        {
            return Call<String>("getFields");
        }

        public DriveRequest<T> SetFields(String var1)
        {
            return CallAsWrapper<DriveRequest<T>>("setFields", var1);
        }

        public String GetForm()
        {
            return Call<String>("getForm");
        }

        public DriveRequest<T> SetForm(String var1)
        {
            return CallAsWrapper<DriveRequest<T>>("setForm", var1);
        }

        public Boolean GetPrettyPrint()
        {
            return Call<Boolean>("getPrettyPrint");
        }

        public DriveRequest<T> SetPrettyPrint(Boolean var1)
        {
            return CallAsWrapper<DriveRequest<T>>("setPrettyPrint", var1);

        }

        public String GetQuotaId()
        {
            return Call<String>("getQuotaId");
        }

        public DriveRequest<T> SetQuotaId(String var1)
        {
            return CallAsWrapper<DriveRequest<T>>("setQuotaId", var1);
        }

        public Drive GetAbstractClient()
        {
            return CallAsWrapper<Drive>("getAbstractClient");
        }

        public DriveRequest<T> SetHeaders(AndroidJavaObject var1)
        {
            return CallAsWrapper<DriveRequest<T>>("setHeaders", var1);
        }

        public DriveRequest<T> SetDisableGZip(bool var1)
        {
            return CallAsWrapper<DriveRequest<T>>("setDisableGZip", var1);
        }

        public DriveRequest<T> Set(String var1, AndroidJavaObject var2)
        {
            return CallAsWrapper<DriveRequest<T>>("set", var1, var2);
        }

    }

}
