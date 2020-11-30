using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.RemoteConfig
{
    public interface IAGConnectConfig
    {
        void applyDefault(Dictionary<String, System.Object> map);
        void applyDefault(String xmlPath);
        void apply(ConfigValues values);
        ITask<ConfigValues> fetch();
        ITask<ConfigValues> fetch(long intervalSeconds);
        Boolean getValueAsBoolean(String key);
        Double getValueAsDouble(String key);
        long getValueAsLong(String key);
        string getValueAsString(string key);
        byte[] getValueAsByteArray(string key);
        Dictionary<String, System.Object> getMergedAll();
        ConfigValues loadLastFetched();
        Constants.SOURCE getSource(String key);
        void clearAll();
        void setDeveloperMode(Boolean isDeveloperMode);
    }
}
