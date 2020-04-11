using System;
using System.Collections;
using System.Collections.Generic;

namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.jos.games.ranking.ScoreSubmissionInfo
    public sealed class ScoreSubmissionInfo : JavaObjectWrapper
    {

        public ScoreSubmissionInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public string RankingId => CallAuto<string>("getRankingId");

        public string PlayerId => CallAuto<string>("getPlayerId");

        public Result GetSubmissionScoreResult(int paramInt) => CallAuto<Result>("getSubmissionScoreResult", paramInt);
    }

}