using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class FileList : JavaObjectWrapper
    {
        
        public FileList(AndroidJavaObject javaObject) : base(javaObject) { }

        public IList<File> GetFiles() => Call<AndroidJavaObject>("getFiles").AsListFromWrappable<File>();

        public String GetNextCursor() => Call<String>("getNextCursor");
    }
}
