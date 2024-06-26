using System;
using System.Text.RegularExpressions;
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

        public void onAudioAvailable(string taskId, AndroidJavaObject audioFragment, int offset , AndroidJavaObject keyValuePairs, AndroidJavaObject bundle)
        {
            // Initialize pairs as null
            Tuple<int, int> pairs = null;

            // Check if keyValuePairs is not null
            if (keyValuePairs != null)
            {
                // Extract the pair values from keyValuePairs
                pairs = ExtractPairFromKeyValuePairs(keyValuePairs);
            }

            // Call the OnAudioAvailable method with the extracted pair and other parameters
            _IMLTtsCallback.OnAudioAvailable(taskId, new MLTtsAudioFragment(audioFragment), offset, pairs , new Bundle(bundle));
        }

        public void onEvent(string taskId, int eventId, AndroidJavaObject bundle)
        {
            _IMLTtsCallback.OnEvent(taskId, eventId, new Bundle(bundle));
        }

        private Tuple<int, int> ExtractPairFromKeyValuePairs(AndroidJavaObject keyValuePairs)
        {
            // Convert keyValuePairs to string
            var stringData = keyValuePairs.Call<string>("toString");

            // Define the regex pattern
            string pattern = @"Pair\{(\d+)\s+(\d+)\}";

            // Match the stringData with the pattern
            var match = Regex.Match(stringData, pattern);

            // If match is successful, parse the values and return as a Tuple
            if (match.Success)
            {
                int firstValue = int.Parse(match.Groups[1].Value);
                int secondValue = int.Parse(match.Groups[2].Value);

                return new Tuple<int, int>(firstValue, secondValue);
            }

            // If no match is found, log it and return null
            Console.WriteLine("No match found for keyValuePairs in MLTtsCallback");
            return null;
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
            
            /// <summary>
            /// Audio stream callback API, which is used to return the synthesized audio data to the app.
            /// </summary>
            /// <param name="taskId"></param>
            /// <param name="audioFragment"></param>
            /// <param name="offset"></param>
            /// <param name="keyValuePairs"></param>
            /// <param name="bundle"></param>
            void OnAudioAvailable(string taskId, MLTtsAudioFragment audioFragment, int offset, Tuple<int, int> keyValuePairs, Bundle bundle);

            /// <summary>
            /// Audio synthesis task callback extension method.
            /// </summary>
            /// <param name="taskId">Task ID.</param>
            /// <param name="eventId">Event ID.</param>
            /// <param name="bundle">Result description.</param>
            void OnEvent(string taskId, int eventId, Bundle bundle);

        }
    }
}
