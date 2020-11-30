using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class DriveRequest<T> : /*JavaObjectWrapper*/AbstractClientRequest<T>{


        //TODO: add parameters
        [UnityEngine.Scripting.Preserve]
        public DriveRequest(AndroidJavaObject javaObject) : base(javaObject) { }
        //[UnityEngine.Scripting.Preserve]
        //public DriveRequest(Drive var1, string var2, string var3, File var4, AndroidJavaObject var5 ) : base(var1, var2, var3, var4, var5) { }
  
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

    public /* readonly*/ Drive GetAbstractClient()
    {
        //return (Drive)base.getAbstractClient();
        return CallAsWrapper<Drive>("getAbstractClient");
    }

    public DriveRequest<T> SetHeaders(AndroidJavaObject var1)
    {
        //return (DriveRequest)super.setHeaders(var1);
        return CallAsWrapper<DriveRequest<T>>("setHeaders", var1);
    }

    public DriveRequest<T> SetDisableGZip(bool var1)
    {
       // return (DriveRequest)super.setDisableGZip(var1);
        return CallAsWrapper<DriveRequest<T>>("setDisableGZip", var1);
    }

    public DriveRequest<T> Set(String var1, AndroidJavaObject var2)
    {
        return CallAsWrapper<DriveRequest<T>>("set", var1, var2);
            //return (DriveRequest)super.set(var1, var2);
    }
}

}
