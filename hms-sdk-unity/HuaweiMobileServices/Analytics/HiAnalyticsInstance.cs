using HuaweiMobileServices.Base;
using HuaweiMobileServices.Nearby.Discovery;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Analystics
{
    public sealed class HiAnalyticsInstance : JavaObjectWrapper
    {
        public HiAnalyticsInstance(AndroidJavaObject hiAnalyticsInstance) : base(hiAnalyticsInstance) { }

        public void SetAnalyticsEnabled(bool enabled) => Call("setAnalyticsEnabled", enabled);

        public void SetAutoCollectionEnabled(bool isEnabled) => Call("setAutoCollectionEnabled", isEnabled);

        public void SetUserId(String id) => Call("setUserId", id);

        public void SetUserProfile(String name, String value) => Call("setUserProfile", name, value);

        public void SetPushToken(String token) => Call("setPushToken", token);

        public void SetMinActivitySessions(long milliseconds) => Call("setMinActivitySessions", milliseconds);

        public void SetSessionDuration(long milliseconds) => Call("setSessionDuration", milliseconds);

        public void SetCurrentActivity(String activityName, String activityClassOverride) => Call("setCurrentActivity", AndroidContext.ActivityContext, activityName, activityClassOverride);

        public void OnEvent(String eventId, Bundle androidBundle) => Call("onEvent", eventId, androidBundle);

        public void ClearCachedData() => Call("clearCachedData");

        public ITask<String> GetAAID() => CallAsWrapper<TaskPrimitive<String>>("getAAID");

        public void RegHmsSvcEvent() => Call("regHmsSvcEvent");

        public void UnRegHmsSvcEvent() => Call("unRegHmsSvcEvent");

        public Map<String, String> GetUserProfiles(bool var1) => CallAsWrapper<Map<String, String>>("getUserProfiles", var1);

        public void PageStart(String pageName, String pageClassOverride) => Call("pageStart", pageName, pageClassOverride);

        public void PageEnd(String pageName) => Call("pageEnd", pageName);

        public void SetReportPolicies(Set<ReportPolicy> policies) => Call("SetReportPolicies", policies);

        public void SetRestrictionEnabled(bool isEnabled) => Call("setRestrictionEnabled", isEnabled);

        public bool IsRestrictionEnabled => Call<bool>("pageEnd");

        public void AddDefaultEventParams(Bundle androidBundle) => Call("addDefaultEventParams", androidBundle);

        public void SetCollectAdsIdEnabled(bool isEnabled) => Call("setCollectAdsIdEnabled", isEnabled);

        public void SetChannel(String channel) => Call("setChannel", channel);

        public void SetPropertyCollection(String property, bool enabled) => Call("setPropertyCollection", property, enabled);
    }
}

