using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class RankingsClientWrapper : JavaObjectWrapper, IRankingsClient
    {
        public RankingsClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<AndroidIntent> TotalRankingsIntent => 
            CallAsWrapper<TaskJavaObjectWrapper<AndroidIntent>>("getTotalRankingsIntent");

        public ITask<AndroidIntent> GetRankingIntent(string paramString, int paramInt) =>
            CallAsWrapper<TaskJavaObjectWrapper<AndroidIntent>>("getRankingIntent", paramString, paramInt);

        public ITask<AndroidIntent> GetRankingIntent(string paramString) =>
            CallAsWrapper<TaskJavaObjectWrapper<AndroidIntent>>("getRankingIntent", paramString);
    }
}
