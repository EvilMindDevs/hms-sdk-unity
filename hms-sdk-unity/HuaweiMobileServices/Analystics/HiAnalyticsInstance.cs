using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Analystics
{

    public sealed class HiAnalyticsInstance : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public HiAnalyticsInstance(AndroidJavaObject hiAnalyticsInstance) : base(hiAnalyticsInstance) {}

        public void setAnalyticsEnabled(bool enabled)
        {
            Call("setAnalyticsEnabled", enabled);
        }
        public void setAutoCollectionEnabled(bool isEnabled)
        {
            Call("setAutoCollectionEnabled", isEnabled);
        }

        public void setUserId(String id)
        {
            Call("setUserId", id);
        }
        public void setUserProfile(String name, String value)
        {
            Call("setUserProfile", name, value);
        }
        public void setPushToken(String token)
        {
            Call("setPushToken", token);
        }
        public void setMinActivitySessions(long milliseconds)
        {
            Call("setMinActivitySessions", milliseconds);
        }
        public void setSessionDuration(long milliseconds)
        {
            Call("setSessionDuration", milliseconds);
        }
        public void setCurrentActivity(String activityName, String activityClassOverride)
        {
            //AndroidContext activity, 
            Call("setCurrentActivity", activityName, activityClassOverride);
        }
        public void onEvent(String eventId, Bundle androidBundle)
        {
            Call("onEvent", eventId, androidBundle);
        }
        public void clearCachedData()
        {
            Call("clearCachedData");
        }
        public Task getAAID()
        {
            return Call<Task>("getAAID"); 
        }
 
        public void regHmsSvcEvent()
        {
            Call("regHmsSvcEvent");
        }
        public void unRegHmsSvcEvent()
        {
            Call("unRegHmsSvcEvent");
        }
        public Map<String, String> getUserProfiles(bool var1)
        {
            return Call<Map<String, String>>("getUserProfiles", var1); 
        }
        public void pageStart(String pageName, String pageClassOverride)
        {
            Call("pageStart", pageName, pageClassOverride);
        }
        public void pageEnd(String pageName)
        {
            Call("pageEnd", pageName);
        }



    }

}

