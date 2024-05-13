using UnityEngine;

namespace HuaweiMobileServices.ML.DownloadModel
{
    // Wrapper for com.huawei.hms.mlsdk.model.download.MLModelDownloadListener
    // https://developer.huawei.com/consumer/en/doc/hiai-References/mlmodeldownloadlistener-0000001159836566
    public class MLModelDownloadListener : AndroidJavaProxy
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.model.download.MLModelDownloadListener";
        private readonly IMLModelDownloadListener mListener;
       
        public MLModelDownloadListener(IMLModelDownloadListener listener) : base(CLASS_NAME)
        {
            mListener = listener;
        }

        public void onProcess(long alreadyDownLength, long totalLength)
        {
            mListener.OnProcess(alreadyDownLength, totalLength);
        }

        public interface IMLModelDownloadListener
        {
            void OnProcess(long alreadyDownLength, long totalLength);

        }
    }
}
