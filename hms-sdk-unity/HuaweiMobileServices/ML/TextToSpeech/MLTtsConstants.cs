using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.ML.TextToSpeech
{
    // https://developer.huawei.com/consumer/en/doc/hiai-References/mlttsconstants-0000001050167598
    public class MLTtsConstants : JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.tts.MLTtsConstants";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public MLTtsConstants(AndroidJavaObject androidJavaObject) : base(androidJavaObject) { }

        #region Constants
        public static int EVENT_PLAY_START => sJavaClass.GetStaticFieldCached<int>(nameof(EVENT_PLAY_START));
        public static int EVENT_PLAY_PAUSE => sJavaClass.GetStaticFieldCached<int>(nameof(EVENT_PLAY_PAUSE));
        public static int EVENT_PLAY_RESUME => sJavaClass.GetStaticFieldCached<int>(nameof(EVENT_PLAY_RESUME));
        public static int EVENT_PLAY_STOP => sJavaClass.GetStaticFieldCached<int>(nameof(EVENT_PLAY_STOP));
        public static int EVENT_SYNTHESIS_START => sJavaClass.GetStaticFieldCached<int>(nameof(EVENT_SYNTHESIS_START));
        public static int EVENT_SYNTHESIS_END => sJavaClass.GetStaticFieldCached<int>(nameof(EVENT_SYNTHESIS_END));
        public static int EVENT_SYNTHESIS_COMPLETE => sJavaClass.GetStaticFieldCached<int>(nameof(EVENT_SYNTHESIS_COMPLETE));
        public static string EVENT_PLAY_STOP_INTERRUPTED => sJavaClass.GetStaticFieldCached<string>(nameof(EVENT_PLAY_STOP_INTERRUPTED));
        public static string EVENT_SYNTHESIS_INTERRUPTED => sJavaClass.GetStaticFieldCached<string>(nameof(EVENT_SYNTHESIS_INTERRUPTED));

        public static int LANGUAGE_AVAILABLE => sJavaClass.GetStaticFieldCached<int>(nameof(LANGUAGE_AVAILABLE));
        public static int LANGUAGE_NOT_SUPPORT => sJavaClass.GetStaticFieldCached<int>(nameof(LANGUAGE_NOT_SUPPORT));
        public static int LANGUAGE_UPDATING => sJavaClass.GetStaticFieldCached<int>(nameof(LANGUAGE_UPDATING));

        public static string TTS_EN_US => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_EN_US));
        public static string TTS_LAN_AR_AR => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_LAN_AR_AR));
        public static string TTS_LAN_TR_TR => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_LAN_TR_TR));
        public static string TTS_LAN_DE_DE => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_LAN_DE_DE));
        public static string TTS_LAN_ES_ES => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_LAN_ES_ES));
        public static string TTS_LAN_FR_FR => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_LAN_FR_FR));
        public static string TTS_LAN_IT_IT => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_LAN_IT_IT));
        public static string TTS_LAN_RU_RU => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_LAN_RU_RU));
        public static string TTS_LAN_PL_PL => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_LAN_PL_PL));
        public static string TTS_LAN_TH_TH => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_LAN_TH_TH));
        public static string TTS_LAN_MS_MS => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_LAN_MS_MS));

        public static string TTS_SPEAKER_FEMALE_EN => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_FEMALE_EN));
        public static string TTS_SPEAKER_FEMALE_ZH_2 => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_FEMALE_ZH_2));
        public static string TTS_SPEAKER_MALE_ZH_2 => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_MALE_ZH_2));
        public static string TTS_SPEAKER_FEMALE_EN_2 => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_FEMALE_EN_2));
        public static string TTS_SPEAKER_MALE_EN_2 => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_MALE_EN_2));
        public static string TTS_SPEAKER_FEMALE_ZH => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_FEMALE_ZH));
        public static string TTS_SPEAKER_MALE_EN => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_MALE_EN));
        public static string TTS_SPEAKER_MALE_ZH => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_MALE_ZH));
        public static string TTS_SPEAKER_FEMALE_DE => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_FEMALE_DE));
        public static string TTS_SPEAKER_FEMALE_AR => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_FEMALE_AR));
        public static string TTS_SPEAKER_FEMALE_TR => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_FEMALE_TR));
        public static string TTS_SPEAKER_FEMALE_IT => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_FEMALE_IT));
        public static string TTS_SPEAKER_FEMALE_ES => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_FEMALE_ES));
        public static string TTS_SPEAKER_FEMALE_FR => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_FEMALE_FR));
        public static string TTS_SPEAKER_FEMALE_RU => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_FEMALE_RU));
        public static string TTS_SPEAKER_FEMALE_PL => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_FEMALE_PL));
        public static string TTS_SPEAKER_FEMALE_TH => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_FEMALE_TH));
        public static string TTS_SPEAKER_FEMALE_MS => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_FEMALE_MS));
        public static string TTS_ZH_HANS => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_ZH_HANS));

        public static string TTS_OFFLINE_MODE => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_OFFLINE_MODE));
        public static string TTS_ONLINE_MODE => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_ONLINE_MODE));

        public static string TTS_SPEAKER_OFFLINE_AR_AR_FEMALE_FLY => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_AR_AR_FEMALE_FLY));
        public static string TTS_SPEAKER_OFFLINE_DE_DE_FEMALE_BEE => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_DE_DE_FEMALE_BEE));
        public static string TTS_SPEAKER_OFFLINE_DE_DE_FEMALE_FLY => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_DE_DE_FEMALE_FLY));
        public static string TTS_SPEAKER_OFFLINE_EN_US_FEMALE_BEE => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_EN_US_FEMALE_BEE));
        public static string TTS_SPEAKER_OFFLINE_EN_US_FEMALE_EAGLE => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_EN_US_FEMALE_EAGLE));
        public static string TTS_SPEAKER_OFFLINE_EN_US_MALE_EAGLE => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_EN_US_MALE_EAGLE));
        public static string TTS_SPEAKER_OFFLINE_EN_US_FEMALE_BOLT => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_EN_US_FEMALE_BOLT));
        public static string TTS_SPEAKER_OFFLINE_EN_US_MALE_BOLT => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_EN_US_MALE_BOLT));
        public static string TTS_SPEAKER_OFFLINE_EN_US_FEMALE_FLY => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_EN_US_FEMALE_FLY));
        public static string TTS_SPEAKER_OFFLINE_ES_ES_FEMALE_BEE => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_ES_ES_FEMALE_BEE));
        public static string TTS_SPEAKER_OFFLINE_ES_ES_FEMALE_FLY => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_ES_ES_FEMALE_FLY));
        public static string TTS_SPEAKER_OFFLINE_FR_FR_FEMALE_BEE => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_FR_FR_FEMALE_BEE));
        public static string TTS_SPEAKER_OFFLINE_FR_FR_FEMALE_FLY => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_FR_FR_FEMALE_FLY));
        public static string TTS_SPEAKER_OFFLINE_IT_IT_FEMALE_BEE => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_IT_IT_FEMALE_BEE));
        public static string TTS_SPEAKER_OFFLINE_IT_IT_FEMALE_FLY => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_IT_IT_FEMALE_FLY));
        public static string TTS_SPEAKER_OFFLINE_RU_RU_FEMALE_FLY => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_RU_RU_FEMALE_FLY));
        public static string TTS_SPEAKER_OFFLINE_TH_TH_FEMALE_FLY => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_TH_TH_FEMALE_FLY));
        public static string TTS_SPEAKER_OFFLINE_ZH_HANS_FEMALE_EAGLE => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_ZH_HANS_FEMALE_EAGLE));
        public static string TTS_SPEAKER_OFFLINE_ZH_HANS_MALE_EAGLE => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_ZH_HANS_MALE_EAGLE));
        public static string TTS_SPEAKER_OFFLINE_ZH_HANS_FEMALE_BOLT => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_ZH_HANS_FEMALE_BOLT));
        public static string TTS_SPEAKER_OFFLINE_ZH_HANS_MALE_BOLT => sJavaClass.GetStaticFieldCached<string>(nameof(TTS_SPEAKER_OFFLINE_ZH_HANS_MALE_BOLT));
        #endregion
    }
}
