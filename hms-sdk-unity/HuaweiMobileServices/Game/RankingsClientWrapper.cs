﻿using System;
using System.Collections.Generic;

namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using System.Threading.Tasks;
    using UnityEngine;

    internal class RankingsClientWrapper : JavaObjectWrapper, IRankingsClient
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.GenericBridge");

        public RankingsClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public void ShowTotalRankings(Action onSuccess, Action<HMSException> onFailure)
        {
            CallAsWrapper<TaskAndroidJavaObject>("getTotalRankingsIntent")
                .AddOnSuccessListener((intent) =>
                {
                    var callback = new GenericBridgeCallbackWrapper()
                       .AddOnFailureListener(onFailure)
                       .AddOnSuccessListener((nothing) =>
                       {
                           CallOnMainThread(() => { onSuccess.Invoke(); });
                       });
                    sJavaClass.CallStatic("receiveShow", intent, callback);

                }).AddOnFailureListener((exception) => CallOnMainThread(() => { onFailure.Invoke(exception); }));
        }

        public System.Threading.Tasks.Task ShowTotalRankingsAsync()
        {
            var task = new TaskCompletionSource<int>();
            ShowTotalRankings(() => task.SetResult(0), task.SetException);
            return task.Task;
        }

        public ITask<RankingScore> GetCurrentPlayerRankingScore(string paramString, int paramInt) =>
            CallAsWrapper<TaskJavaObjectWrapper<RankingScore>>("getCurrentPlayerRankingScore", paramString, paramInt);

        public ITask<RankingScores> GetMoreRankingScores(string paramString, long paramLong, int paramInt1, int paramInt2, int paramInt3) =>
            CallAsWrapper<TaskJavaObjectWrapper<RankingScores>>("getMoreRankingScores", paramString, paramLong, paramInt1, paramInt2, paramInt3);

        public ITask<RankingScores> GetPlayerCenteredRankingScores(string paramString, int paramInt1, int paramInt2, bool paramBoolean) =>
            CallAsWrapper<TaskJavaObjectWrapper<RankingScores>>("getPlayerCenteredRankingScores", paramString, paramInt1, paramInt2, paramBoolean);

        public ITask<RankingScores> GetPlayerCenteredRankingScores(string paramString, int paramInt1, int paramInt2, long paramLong, int paramInt3) =>
            CallAsWrapper<TaskJavaObjectWrapper<RankingScores>>("getPlayerCenteredRankingScores", paramString, paramInt1, paramInt2, paramLong, paramInt3);

        public ITask<AndroidIntent> GetRankingIntent(string rankingId, int timeDimension) =>
            CallAsWrapper<TaskJavaObjectWrapper<AndroidIntent>>("getRankingIntent", rankingId, timeDimension);

        public ITask<AndroidIntent> GetRankingIntent(string rankingId) =>
            CallAsWrapper<TaskJavaObjectWrapper<AndroidIntent>>("getRankingIntent", rankingId);

        public ITask<IList<Ranking>> GetRankingSummary(bool paramBoolean)
        {
            var task = Call<AndroidJavaObject>("getRankingSummary", paramBoolean);
            return new TaskWrapper<IList<Ranking>>(task, AndroidJavaObjectExtensions.AsListFromWrappable<Ranking>);
        }

        public ITask<Ranking> GetRankingSummary(string paramString, bool paramBoolean) =>
            CallAsWrapper<TaskJavaObjectWrapper<Ranking>>("getRankingSummary", paramString, paramBoolean);

        public ITask<int> GetRankingSwitchStatus() => CallAsWrapper<TaskPrimitive<int>>("getRankingSwitchStatus");

        public ITask<RankingScores> GetRankingTopScores(string paramString, int paramInt1, int paramInt2, long paramLong, int paramInt3) =>
            CallAsWrapper<TaskJavaObjectWrapper<RankingScores>>("getRankingTopScores", paramString, paramInt1, paramInt2, paramLong, paramInt3);

        public ITask<RankingScores> GetRankingTopScores(string paramString, int paramInt1, int paramInt2, bool paramBoolean) =>
            CallAsWrapper<TaskJavaObjectWrapper<RankingScores>>("getRankingTopScores", paramString, paramInt1, paramInt2, paramBoolean);

        public ITask<int> SetRankingSwitchStatus(int paramInt) => CallAsWrapper<TaskPrimitive<int>>("setRankingSwitchStatus", paramInt);

        public void SubmitRankingScore(string rankingId, long score, string scoreTips) =>
            Call("submitRankingScore", rankingId, score, scoreTips);

        public void SubmitRankingScore(string rankingId, long score) => Call("submitRankingScore", rankingId, score);

        public ITask<ScoreSubmissionInfo> SubmitScoreWithResult(string paramString1, long paramLong, string paramString2) =>
            CallAsWrapper<TaskJavaObjectWrapper<ScoreSubmissionInfo>>("submitScoreWithResult", paramString1, paramLong, paramString2);

        public ITask<ScoreSubmissionInfo> SubmitScoreWithResult(string paramString, long paramLong) =>
            CallAsWrapper<TaskJavaObjectWrapper<ScoreSubmissionInfo>>("submitScoreWithResult", paramString, paramLong);
    }
}
