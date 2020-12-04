using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.RemoteConfig
{
    public interface IAGConnectConfig
    {
        void ApplyDefault(Dictionary<string, object> map);
        void ApplyDefault(String xmlPath);
        void Apply(ConfigValues values);
        ITask<ConfigValues> Fetch();
        ITask<ConfigValues> Fetch(long intervalSeconds);
        Boolean GetValueAsBoolean(String key);
        Double GetValueAsDouble(String key);
        long GetValueAsLong(String key);
        string GetValueAsString(string key);
        byte[] GetValueAsByteArray(string key);
        Dictionary<string, object> GetMergedAll();
        ConfigValues LoadLastFetched();
        string GetSource(String key);
        void ClearAll();
        Boolean DeveloperMode { set; }
    }
}
