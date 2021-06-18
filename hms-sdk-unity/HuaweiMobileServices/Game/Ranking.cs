using System.Collections.Generic;

namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.ranking.Ranking
    public class Ranking : JavaObjectWrapper
    {
        public Ranking(AndroidJavaObject javaObject) : base(javaObject) { }

        public const int SCORE_VALUE_HIGH_BETTER = 1;
        public const int SCORE_VALUE_SMALL_BETTER = 0;

        public virtual string RankingDisplayName => CallAsString("getRankingDisplayName");

        public virtual string RankingImageUri => CallAsUriString("getRankingImageUri");

        public virtual string RankingId => CallAsString("getRankingId");

        public virtual int RankingScoreOrder => Call<int>("getRankingScoreOrder");

        public virtual IList<RankingVariant> RankingVariants =>
            Call<AndroidJavaObject>("getRankingVariants").AsListFromWrappable<RankingVariant>();

    }

}