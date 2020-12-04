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

        public string GetValueAsString(string paramString) => Call<string>("getValueAsString", paramString);

        public bool GetValueAsBoolean(string paramString) => Call<bool>("getValueAsBoolean", paramString);

        public double GetValueAsDouble(string paramString) => Call<double>("getValueAsDouble", paramString);

        public long GetValueAsLong(string paramString) => Call<long>("getValueAsLong", paramString);

        public byte[] GetValueAsByteArray(string paramString) => Call<byte[]>("getValueAsByteArray", paramString);

        public void ApplyDefault(Dictionary<string, object> map) => Call("applyDefault", map.AsJavaHashMap()); 

        public void ApplyDefault(string xmlPath) => Call("applyDefault", DictionaryOperations.XMLtoDictionary(xmlPath).AsJavaHashMap());

        public void Apply(ConfigValues values) => Call("apply", values);

        public void ClearAll() => Call("clearAll");

        public Boolean DeveloperMode
        {
            set => Call("setDeveloperMode", value);
        }

        public Dictionary<string, object> GetMergedAll() => Call<AndroidJavaObject>("getMergedAll").AsDictionary();

        public ConfigValues LoadLastFetched() => CallAsWrapper<ConfigValues>("loadLastFetched");

        public string GetSource(string key) 
        {
            AndroidJavaObject getSource = Call<AndroidJavaObject>("getSource", key); 
            return getSource.Call<string>("toString");
        }

        public ITask<ConfigValues> Fetch() => CallAsWrapper<TaskJavaObjectWrapper<ConfigValues>>("fetch");

        public ITask<ConfigValues> Fetch(long intervalSeconds) => CallAsWrapper<TaskJavaObjectWrapper<ConfigValues>>("fetch", intervalSeconds);

    }
}
