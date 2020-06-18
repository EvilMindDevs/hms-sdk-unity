using System.Collections.Generic;

namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.ranking.Ranking
    public class Ranking : JavaObjectWrapper
    {

        private const string CLASS_NAME = "com.huawei.hms.jos.games.ranking.Ranking";

        [UnityEngine.Scripting.Preserve]
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public const int SCORE_VALUE_HIGH_BETTER = 1;

        public const int SCORE_VALUE_SMALL_BETTER = 0;

        public Ranking(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string RankingDisplayName => CallAsString("getRankingDisplayName");

        public virtual string RankingImageUri => CallAsUriString("getRankingImageUri");

        public virtual string RankingId => CallAsString("getRankingId");

        public virtual int RankingScoreOrder => Call<int>("getRankingScoreOrder");

        public virtual IList<RankingVariant> RankingVariants =>
            Call<AndroidJavaObject>("getRankingVariants").AsListFromWrappable<RankingVariant>();

    }

}