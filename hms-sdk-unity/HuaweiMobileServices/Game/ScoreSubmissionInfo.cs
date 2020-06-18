namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.ranking.ScoreSubmissionInfo
    public sealed class ScoreSubmissionInfo : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public ScoreSubmissionInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public string RankingId => CallAsString("getRankingId");

        public string PlayerId => CallAsString("getPlayerId");

        public Result GetSubmissionScoreResult(int paramInt) => CallAsWrapper<Result>("getSubmissionScoreResult", paramInt);

    }

}