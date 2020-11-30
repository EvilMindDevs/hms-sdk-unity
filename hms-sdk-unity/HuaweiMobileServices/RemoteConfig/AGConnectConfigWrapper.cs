using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.RemoteConfig
{
    class AGConnectConfigWrapper : JavaObjectWrapper, IAGConnectConfig
    {
        [UnityEngine.Scripting.Preserve]
        public AGConnectConfigWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public string getValueAsString(string paramString) => Call<string>("getValueAsString", paramString);

        public bool getValueAsBoolean(string paramString) => Call<bool>("getValueAsBoolean", paramString);

        public double getValueAsDouble(string paramString) => Call<double>("getValueAsDouble", paramString);

        public long getValueAsLong(string paramString) => Call<long>("getValueAsLong", paramString);

        public byte[] getValueAsByteArray(string paramString) => Call<byte[]>("getValueAsByteArray", paramString);

        public void applyDefault(Dictionary<String, System.Object> map) => Call("applyDefault", DictionaryOperations.DictionaryToAndroidJavaObject(map));

        public void applyDefault(string xmlPath) => Call("applyDefault", DictionaryOperations.DictionaryToAndroidJavaObject(DictionaryOperations.XMLtoDictionary(xmlPath)));

        public void apply(ConfigValues values) => Call("apply", values);

        public void clearAll() => Call("clearAll");

        public void setDeveloperMode(bool isDeveloperMode) => Call("setDeveloperMode", isDeveloperMode);

        public Dictionary<String, System.Object> getMergedAll() => DictionaryOperations.AndroidJavaObjectToDictionary(Call<AndroidJavaObject>("getMergedAll"));

        public ConfigValues loadLastFetched() => Call<ConfigValues>("loadLastFetched");

        public Constants.SOURCE getSource(string key) => Call<Constants.SOURCE>("getSource", key);

        public ITask<ConfigValues> fetch() => CallAsWrapper<TaskJavaObjectWrapper<ConfigValues>>("fetch");

        public ITask<ConfigValues> fetch(long intervalSeconds) => CallAsWrapper<TaskJavaObjectWrapper<ConfigValues>>("fetch", intervalSeconds);
    }
}
