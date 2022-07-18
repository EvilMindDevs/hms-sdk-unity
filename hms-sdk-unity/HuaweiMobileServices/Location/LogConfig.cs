using HuaweiMobileServices.Utils;
using UnityEngine;


namespace HuaweiMobileServices.Location
{
    public class LogConfig : JavaObjectWrapper
    {
        public LogConfig(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.LogConfig");

        public LogConfig() : base("com.huawei.hms.location.LogConfig") { }

        public LogConfig(string logPath) : base("com.huawei.hms.location.LogConfig", logPath.AsJavaString()) { }

        public LogConfig(string logPath, int fileSize, int fileNum, int fileExpiredTime) : base("com.huawei.hms.location.LogConfig", logPath.AsJavaString(), fileSize, fileNum, fileExpiredTime) { }

        public int GetFileExpiredTime() => Call<int>("getFileExpiredTime");

        public int GetFileNum() => Call<int>("getFileNum");

        public int GetFileSize() => Call<int>("getFileSize");

        public string GetLogPath() => CallAsString("getLogPath");

        public void SetFileExpiredTime(int fileExpiredTime) => Call("setFileExpiredTime", fileExpiredTime);

        public void SetFileNum(int fileNum) => Call("setFileNum", fileNum);

        public void SetFileSize(int fileSize) => Call("setFileSize", fileSize);

        public void SetLogPath(string logPath) => Call("setLogPath", logPath.AsJavaString());

    }
}

