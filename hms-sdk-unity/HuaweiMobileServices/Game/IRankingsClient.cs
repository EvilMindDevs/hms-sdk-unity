using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.jos.games.RankingsClient
    public interface IRankingsClient
    {

        void ShowTotalRankings(Action onSuccess, Action<HMSException> onFailure);

        Task ShowTotalRankingsAsync();

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

    }

}