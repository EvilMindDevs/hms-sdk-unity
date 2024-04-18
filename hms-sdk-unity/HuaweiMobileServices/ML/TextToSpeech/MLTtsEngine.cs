using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.ML.TextToSpeech
{
    public class MLTtsEngine: JavaObjectWrapper
    {
        const string CLASS_NAME = "com.huawei.hms.mlsdk.tts.MLTtsEngine";
        public MLTtsEngine() : base(CLASS_NAME) { }
        public MLTtsEngine(MLTtsConfig paramMLTtsConfig) : base(CLASS_NAME, paramMLTtsConfig) { }
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        /// <summary>
        /// Serial queuing mode. In this mode, multiple audio synthesis tasks are executed in the call sequence.
        /// </summary>
        /// <value>0</value>
        public static int QUEUE_APPEND => sJavaClass.GetStatic<int>(nameof(QUEUE_APPEND));
        /// <summary>
        /// Queue clear mode. In this mode, the audio synthesis tasks to be executed are cleared, 
        /// the audio synthesis task being executed is stopped, and a specified audio synthesis task is executed.
        /// </summary>
        /// <value>1</value>
        public static int QUEUE_FLUSH => sJavaClass.GetStatic<int>(nameof(QUEUE_FLUSH));
        /// <summary>
        /// The audio synthesized by the TTS engine is not automatically played by the internal player.
        /// </summary>
        /// <value>2</value>
        public static int EXTERNAL_PLAYBACK => sJavaClass.GetStatic<int>(nameof(EXTERNAL_PLAYBACK));
        /// <summary>
        /// The audio synthesized by the TTS engine is returned to the app through onAudioAvailable.
        /// </summary>
        /// <value>4</value>
        /// <remarks>
        /// onAudioAvailable is called when the audio synthesis task is completed.
        /// </remarks>
        /// <seealso cref="MLTtsCallback" href="https://developer.huawei.com/consumer/en/doc/hiai-References/mlttscallback-0000001205036619#section18852205617712"/>
        public static int OPEN_STREAM => sJavaClass.GetStatic<int>(nameof(OPEN_STREAM));


        public IList<string> GetLanguages() => Call<List<string>>("getLanguages");
        public IList<string> GetHQLanguages() => Call<List<string>>("getHqLanguages");
        /// <summary>
        /// Obtains the speaker list of the specified language.
        /// </summary>
        /// <param name="language">Language code, for example, MLTtsConstants.TTS_EN_US.</param>
        /// <returns>Speaker list.</returns>
        public IList<MLTtsSpeaker> GetSpeaker(string language) => CallAsWrapperList<MLTtsSpeaker>("getSpeaker",language);
        public IList<MLTtsSpeaker> GetHqSpeaker(string language) => CallAsWrapperList<MLTtsSpeaker>("getHqSpeaker",language);
        /// <summary>
        /// Obtains the speaker list of all languages.
        /// </summary>
        /// <returns>Speaker list.</returns>
        public IList<MLTtsSpeaker> GetSpeakers() => CallAsWrapperList<MLTtsSpeaker>("getSpeakers");
        public IList<MLTtsSpeaker> GetHQSpeakers() => CallAsWrapperList<MLTtsSpeaker>("getHqSpeakers");
        /// <summary>
        /// Checks whether the specified language is supported.
        /// </summary>
        /// <param name="language">Language code, for example, MLTtsConstants.TTS_EN_US.</param>
        /// <returns>0: Supported; 1: Not supported; 2: Being updated.</returns>
        /// <seealso cref="MLTtsConstants" href="https://developer.huawei.com/consumer/en/doc/hiai-References/mlttsconstants-0000001050167598"/>
        public int IsLanguageAvailable(string language) => Call<int>("isLanguageAvailable", language);
        public void Pause() => Call("pause");
        public void Resume() => Call("resume");
        public void Stop() => Call("stop");
        public void Shutdown() => Call("shutdown");
        /// <summary>
        /// Sets the volume of the built-in player, in dBs. The value is in the range of [0, 100].
        /// </summary>
        /// <param name="volume">Volume of the internal player. The value ranges from 0 to 100. The default value is 50.</param>
        public void SetPlayerVolume(int volume) => Call("setPlayerVolume", volume);
        /// <summary>
        /// Sets the TTS callback.
        /// </summary>
        /// <param name="paramMLTtsCallback"></param>
        public void SetTtsCallback(MLTtsCallback paramMLTtsCallback) => Call("setTtsCallback", paramMLTtsCallback);
        /// <summary>
        /// API for real-time speech synthesis and playback.
        /// </summary>
        /// <param name="mode">TTS playback mode. Currently, QUEUE_APPEND, QUEUE_FLUSH, OPEN_STREAM, and EXTERNAL_PLAYBACK are supported.</param>
        /// <param name="text">Text to be converted to speech. The text can contain a maximum of 500 characters.</param>
        /// <seealso cref="QUEUE_APPEND" href="https://developer.huawei.com/consumer/en/doc/hiai-References/mlttsengine-0000001050169553#section19556135953720"/>
        /// <returns>ID of the audio synthesis task.</returns>
        /// <seealso cref="speak" href="https://developer.huawei.com/consumer/en/doc/hiai-References/mlttsengine-0000001050169553#section13330101397"/>
        public string Speak(string text, int mode) => Call<string>("speak", text, mode);
        public void UpdateConfig(MLTtsConfig mLTtsConfig) => Call("updateConfig", mLTtsConfig);
    }
}
