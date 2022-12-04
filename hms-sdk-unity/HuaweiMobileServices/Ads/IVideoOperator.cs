using HuaweiMobileServices.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.Ads
{
    public class VideoOperator : AndroidJavaProxy
    {

        private readonly IVideoOperator IvideoOperator;

        public VideoOperator(IVideoOperator videoOperator) : base("com.huawei.hms.ads.VideoOperator")
        {
            IvideoOperator = videoOperator;
        }

        public float getAspectRatio()
        {
            return IvideoOperator.getAspectRatio();
        }

        public VideoOperator.VideoLifecycleListener getVideoLifecycleListener()
        {
            return IvideoOperator.getVideoLifecycleListener();
        }

        public bool hasVideo()
        {
            return IvideoOperator.hasVideo();
        }

        public bool isCustomizeOperateEnabled()
        {
            return IvideoOperator.isCustomizeOperateEnabled();
        }

        public bool isMuted()
        {
            return IvideoOperator.isMuted();
        }

        public void mute(bool mute)
        {
            IvideoOperator.mute(mute);
        }
        public void pause()
        {
            IvideoOperator.pause();
        }
        public void play()
        {
            IvideoOperator.play();
        }
        public void setVideoLifecycleListener(VideoOperator.VideoLifecycleListener listener)
        {
            IvideoOperator.setVideoLifecycleListener(listener);
        }
        public void stop()
        {
            IvideoOperator.stop();
        }

        //wrapper for com.huawei.hms.ads.VideoOperator$VideoLifecycleListener
        //https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/videolifecyclelistener-0000001050066841
        public abstract class VideoLifecycleListener : JavaObjectWrapper
        {
            public VideoLifecycleListener(AndroidJavaObject javaObject) : base(javaObject) { }

            public VideoLifecycleListener() : base("com.huawei.hms.ads.VideoOperator$VideoLifecycleListener") { }

            private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ads.VideoOperator$VideoLifecycleListener");
           
            public void onVideoEnd() => Call("onVideoEnd");

            public void onVideoMute(bool isMuted) => Call("onVideoMute", isMuted);
           
            public void onVideoPause() => Call("onVideoPause");

            public void onVideoPlay() => Call("onVideoPlay");

            public void onVideoStart() => Call("onVideoStart");
        }
    }

    public interface IVideoOperator
    {
        float getAspectRatio();

        bool hasVideo();

        bool isClickToFullScreenEnabled();

        bool isCustomizeOperateEnabled();

        bool isMuted();

        void mute(bool mute);

        void pause();

        void play();

        void setVideoLifecycleListener(VideoOperator.VideoLifecycleListener videoLifecycleListener);

        VideoOperator.VideoLifecycleListener getVideoLifecycleListener();

        void stop();
    }

}
