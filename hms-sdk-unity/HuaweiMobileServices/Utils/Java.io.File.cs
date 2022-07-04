using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Utils.java.io
{
        public class File : JavaObjectWrapper
        {

            private const string CLASS_NAME = "java.io.File";

            public File(AndroidJavaObject javaObject) : base(javaObject) { }
            public File(string pathname) : base(CLASS_NAME, pathname.AsJavaString()) { }

            public bool Exists() => Call<bool>("exists");
        }

        public class FileOutputStream : JavaObjectWrapper
        {

            private const string CLASS_NAME = "java.io.FileOutputStream";

            public FileOutputStream(AndroidJavaObject javaObject) : base(javaObject) { }
            public FileOutputStream(File file) : base(CLASS_NAME, file.JavaObject) { }

        }
}
