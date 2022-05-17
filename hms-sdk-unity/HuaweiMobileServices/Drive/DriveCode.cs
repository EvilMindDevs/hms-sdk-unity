namespace HuaweiMobileServices.Drive
{
    using HuaweiMobileServices.Utils;
    using System;
    using System.Collections.Generic;
    using UnityEngine;

    public class DriveCode : JavaObjectWrapper
    {
        public DriveCode(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass JavaClass = new AndroidJavaClass("com.huawei.cloud.client.exception.DriveCode");

        public static int SUCCESS => JavaClass.GetStatic<int>("SUCCESS");
        public static int PARAMS => JavaClass.GetStatic<int>("PARAMS");
        public static int ERROR => JavaClass.GetStatic<int>("ERROR");
        public static int HTTPERROR => JavaClass.GetStatic<int>("HTTPERROR");
        public static int SERVICE_URL_NOT_ENABLED => JavaClass.GetStatic<int>("SERVICE_URL_NOT_ENABLED");
        public static int HASH_INVALID => JavaClass.GetStatic<int>("HASH_INVALID");
        public static int DATABASE_ERROR => JavaClass.GetStatic<int>("DATABASE_ERROR");
        public static int DATASDK_ERROR => JavaClass.GetStatic<int>("DATASDK_ERROR");
        public static int USERKEY_ERROR => JavaClass.GetStatic<int>("USERKEY_ERROR");
        public static int DRIVESERVER_ERROR => JavaClass.GetStatic<int>("DRIVESERVER_ERROR");
        public static int DATA_INTERRUPT => JavaClass.GetStatic<int>("DATA_INTERRUPT");
        public static int ECDH_ERROR => JavaClass.GetStatic<int>("ECDH_ERROR");
        public static int AES_ERROR => JavaClass.GetStatic<int>("AES_ERROR");
        public static int ENCRYPT_ERROR => JavaClass.GetStatic<int>("ENCRYPT_ERROR");
        public static int DECRYPT_ERROR => JavaClass.GetStatic<int>("DECRYPT_ERROR");
    }
}