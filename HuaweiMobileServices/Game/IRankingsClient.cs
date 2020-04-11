using System.Collections.Generic;

namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.RankingsClient
    public interface IRankingsClient
    {
        ITask<AndroidIntent> TotalRankingsIntent { get; }

        ITask<AndroidIntent> GetRankingIntent(string paramString, int paramInt);

        ITask<AndroidIntent> GetRankingIntent(string paramString);

        ITask<RankingScores> GetRankingTopScores(string paramString, int paramInt1, int paramInt2, long paramLong, int paramInt3);

        ITask<RankingScores> GetRankingTopScores(string paramString, int paramInt1, int paramInt2, bool paramBoolean);

        void SubmitRankingScore(string paramString1, long paramLong, string paramString2);

        void SubmitRankingScore(string paramString, long paramLong);

        ITask<ScoreSubmissionInfo> SubmitScoreWithResult(string paramString1, long paramLong, string paramString2);

        ITask<ScoreSubmissionInfo> SubmitScoreWithResult(string paramString, long paramLong);

        ITask<int> GetRankingSwitchStatus();

        ITask<int> SetRankingSwitchStatus(int paramInt);

        ITask<RankingScore> GetCurrentPlayerRankingScore(string paramString, int paramInt);

        ITask<IList<Ranking>> GetRankingSummary(bool paramBoolean);

        ITask<Ranking> GetRankingSummary(string paramString, bool paramBoolean);

        ITask<RankingScores> GetMoreRankingScores(string paramString, long paramLong, int paramInt1, int paramInt2, int paramInt3);

        ITask<RankingScores> GetPlayerCenteredRankingScores(string paramString, int paramInt1, int paramInt2, bool paramBoolean);

        ITask<RankingScores> GetPlayerCenteredRankingScores(string paramString, int paramInt1, int paramInt2, long paramLong, int paramInt3);

        // TODO
    }

}