using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.ML.TextToSpeech
{
    //https://developer.huawei.com/consumer/en/doc/hiai-References/mlttsconstants-0000001050167598
    public class MLTtsConstants: JavaObjectWrapper
    {
        const string CLASS_NAME = "com.huawei.hms.mlsdk.tts.MLTtsConstants";
        public MLTtsConstants(AndroidJavaObject androidJavaObject) : base(androidJavaObject) { }
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);
        
        #region Constants
        public static int EVENT_PLAY_START => sJavaClass.GetStatic<int>(nameof(EVENT_PLAY_START));
        public static int EVENT_PLAY_PAUSE => sJavaClass.GetStatic<int>(nameof(EVENT_PLAY_PAUSE));
        public static int EVENT_PLAY_RESUME => sJavaClass.GetStatic<int>(nameof(EVENT_PLAY_RESUME));
        public static int EVENT_PLAY_STOP => sJavaClass.GetStatic<int>(nameof(EVENT_PLAY_STOP));
        public static int EVENT_SYNTHESIS_START => sJavaClass.GetStatic<int>(nameof(EVENT_SYNTHESIS_START));
        public static int EVENT_SYNTHESIS_END => sJavaClass.GetStatic<int>(nameof(EVENT_SYNTHESIS_END));
        public static int EVENT_SYNTHESIS_COMPLETE => sJavaClass.GetStatic<int>(nameof(EVENT_SYNTHESIS_COMPLETE));
        public static string EVENT_PLAY_STOP_INTERRUPTED => sJavaClass.GetStatic<string>(nameof(EVENT_PLAY_STOP_INTERRUPTED));
        public static string EVENT_SYNTHESIS_INTERRUPTED => sJavaClass.GetStatic<string>(nameof(EVENT_SYNTHESIS_INTERRUPTED));
        public static int LANGUAGE_AVAILABLE => sJavaClass.GetStatic<int>(nameof(LANGUAGE_AVAILABLE));
        public static int LANGUAGE_NOT_SUPPORT => sJavaClass.GetStatic<int>(nameof(LANGUAGE_NOT_SUPPORT));
        public static int LANGUAGE_UPDATING => sJavaClass.GetStatic<int>(nameof(LANGUAGE_UPDATING));
        public static string TTS_EN_US => sJavaClass.GetStatic<string>(nameof(TTS_EN_US));
        public static string TTS_LAN_AR_AR => sJavaClass.GetStatic<string>(nameof(TTS_LAN_AR_AR));
        public static string TTS_LAN_TR_TR => sJavaClass.GetStatic<string>(nameof(TTS_LAN_TR_TR));
        public static string TTS_LAN_DE_DE => sJavaClass.GetStatic<string>(nameof(TTS_LAN_DE_DE));
        public static string TTS_LAN_ES_ES => sJavaClass.GetStatic<string>(nameof(TTS_LAN_ES_ES));
        public static string TTS_LAN_FR_FR => sJavaClass.GetStatic<string>(nameof(TTS_LAN_FR_FR));
        public static string TTS_LAN_IT_IT => sJavaClass.GetStatic<string>(nameof(TTS_LAN_IT_IT));
        public static string TTS_LAN_RU_RU => sJavaClass.GetStatic<string>(nameof(TTS_LAN_RU_RU));
        public static string TTS_LAN_PL_PL => sJavaClass.GetStatic<string>(nameof(TTS_LAN_PL_PL));
        public static string TTS_LAN_TH_TH => sJavaClass.GetStatic<string>(nameof(TTS_LAN_TH_TH));
        public static string TTS_LAN_MS_MS => sJavaClass.GetStatic<string>(nameof(TTS_LAN_MS_MS));
        public static string TTS_SPEAKER_FEMALE_EN => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_FEMALE_EN));
        public static string TTS_SPEAKER_FEMALE_ZH_2 => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_FEMALE_ZH_2));
        public static string TTS_SPEAKER_MALE_ZH_2 => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_MALE_ZH_2));
        public static string TTS_SPEAKER_FEMALE_EN_2 => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_FEMALE_EN_2));
        public static string TTS_SPEAKER_MALE_EN_2 => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_MALE_EN_2));
        public static string TTS_SPEAKER_FEMALE_ZH => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_FEMALE_ZH));
        public static string TTS_SPEAKER_MALE_EN => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_MALE_EN));
        public static string TTS_SPEAKER_MALE_ZH => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_MALE_ZH));
        public static string TTS_SPEAKER_FEMALE_DE => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_FEMALE_DE));
        public static string TTS_SPEAKER_FEMALE_AR => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_FEMALE_AR));
        public static string TTS_SPEAKER_FEMALE_TR => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_FEMALE_TR));
        public static string TTS_SPEAKER_FEMALE_IT => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_FEMALE_IT));
        public static string TTS_SPEAKER_FEMALE_ES => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_FEMALE_ES));
        public static string TTS_SPEAKER_FEMALE_FR => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_FEMALE_FR));
        public static string TTS_SPEAKER_FEMALE_RU => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_FEMALE_RU));
        public static string TTS_SPEAKER_FEMALE_PL => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_FEMALE_PL));
        public static string TTS_SPEAKER_FEMALE_TH => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_FEMALE_TH));
        public static string TTS_SPEAKER_FEMALE_MS => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_FEMALE_MS));
        public static string TTS_ZH_HANS => sJavaClass.GetStatic<string>(nameof(TTS_ZH_HANS));
        public static string TTS_OFFLINE_MODE => sJavaClass.GetStatic<string>(nameof(TTS_OFFLINE_MODE));
        public static string TTS_ONLINE_MODE => sJavaClass.GetStatic<string>(nameof(TTS_ONLINE_MODE));
        public static string TTS_SPEAKER_OFFLINE_DE_DE_FEMALE_BEE => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_OFFLINE_DE_DE_FEMALE_BEE)); 
        public static string TTS_SPEAKER_OFFLINE_EN_US_FEMALE_BEE => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_OFFLINE_EN_US_FEMALE_BEE));
        public static string TTS_SPEAKER_OFFLINE_EN_US_FEMALE_EAGLE => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_OFFLINE_EN_US_FEMALE_EAGLE));
        public static string TTS_SPEAKER_OFFLINE_EN_US_MALE_EAGLE => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_OFFLINE_EN_US_MALE_EAGLE));
        public static string TTS_SPEAKER_OFFLINE_ES_ES_FEMALE_BEE => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_OFFLINE_ES_ES_FEMALE_BEE));
        public static string TTS_SPEAKER_OFFLINE_FEMALE_DE => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_OFFLINE_FEMALE_DE));
        public static string TTS_SPEAKER_OFFLINE_FEMALE_IT => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_OFFLINE_FEMALE_IT));
        public static string TTS_SPEAKER_OFFLINE_FR_FR_FEMALE_BEE => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_OFFLINE_FR_FR_FEMALE_BEE));
        public static string TTS_SPEAKER_OFFLINE_IT_IT_FEMALE_BEE => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_OFFLINE_IT_IT_FEMALE_BEE));
        public static string TTS_SPEAKER_OFFLINE_ZH_HANS_FEMALE_EAGLE => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_OFFLINE_ZH_HANS_FEMALE_EAGLE));
        public static string TTS_SPEAKER_OFFLINE_ZH_HANS_MALE_EAGLE => sJavaClass.GetStatic<string>(nameof(TTS_SPEAKER_OFFLINE_ZH_HANS_MALE_EAGLE));
        #endregion  
    

    }
}
