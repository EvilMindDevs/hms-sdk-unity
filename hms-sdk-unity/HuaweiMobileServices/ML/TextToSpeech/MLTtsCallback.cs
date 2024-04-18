using System;
using System.Collections.Generic;
using System.Text;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.ML.TextToSpeech
{
    /// <summary>
    /// Wrapper for com.huawei.hms.mlsdk.tts.MLTtsCallback.
    /// <see cref="MLTtsCallback" link=" https://developer.huawei.com/consumer/en/doc/hiai-References/mlttscallback-0000001205036619"/>
    /// </summary>
    public class MLTtsCallback : AndroidJavaProxy
    {
        private readonly IMLTtsCallback _IMLTtsCallback;

        public MLTtsCallback(IMLTtsCallback ICallback) : base("com.huawei.hms.mlsdk.tts.MLTtsCallback")
        {
            _IMLTtsCallback = ICallback;
        }

        public void onError(string taskId, AndroidJavaObject err)
        {
            _IMLTtsCallback.OnError(taskId, new MLTtsError(err));
        }

        public void onWarn(string taskId, AndroidJavaObject warn)
        {
            _IMLTtsCallback.OnWarn(taskId, new MLTtsWarn(warn));
        }

        public void onRangeStart(string taskId, int start, int end)
        {
            _IMLTtsCallback.OnRangeStart(taskId, start, end);
        }

        public void onAudioAvailable(string taskId, MLTtsAudioFragment audioFragment, KeyValuePair<int, int> keyValuePairs, int offset, Bundle bundle)
        {
            _IMLTtsCallback.OnAudioAvailable(taskId, audioFragment, keyValuePairs, offset, bundle);
        }

        public void onEvent(string taskId, int eventId, AndroidJavaObject bundle)
        {
            _IMLTtsCallback.OnEvent(taskId, eventId, bundle);
        }


        public interface IMLTtsCallback
        {
            /// <summary>
            /// Error event callback function.
            /// </summary>
            /// <param name="taskId"></param>
            /// <param name="err"></param>
            void OnError(string taskId, MLTtsError err);

            /// <summary>
            /// External alarm event.
            /// </summary>
            /// <param name="taskId"></param>
            /// <param name="warn"></param>
            void OnWarn(string taskId, MLTtsWarn warn);

            /// <summary>
            /// The TTS engine splits the text input by the audio synthesis task. This callback function can be used to listen to the playback start event of the split text.
            /// </summary>
            /// <param name="taskId"></param>
            /// <param name="start"></param>
            /// <param name="end"></param>
            void OnRangeStart(string taskId, int start, int end);

            void OnAudioAvailable(string taskId, MLTtsAudioFragment audioFragment, KeyValuePair<int,int> keyValuePairs, int offset, Bundle bundle);

            /// <summary>
            /// Audio synthesis task callback extension method.
            /// </summary>
            /// <param name="taskId">Task ID.</param>
            /// <param name="eventId">Event ID.</param>
            /// <param name="bundle">Result description.</param>
            void OnEvent(string taskId, int eventId, AndroidJavaObject bundle);

        }
    }
}
