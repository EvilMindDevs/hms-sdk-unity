namespace HuaweiMobileServices.Scan
{
    using HuaweiMobileServices.Utils;

    using UnityEngine;

    using Rect = HuaweiMobileServices.Rect;

    internal class RemoteView : JavaObjectWrapper
    {
        public RemoteView(AndroidJavaObject javaObject) : base(javaObject) { }
        public RemoteView() : base("com.huawei.hms.hmsscankit.RemoteView") { }

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.hmsscankit.RemoteView");

        public bool GetLightStatus => Call<bool>("getLightStatus");
        public void OnEvent(Bundle androidBundle) => Call("onCreate", androidBundle);
        public void OnDestroy() => Call("onDestroy");
        public void OnPause() => Call("onPause");
        public void OnResume() => Call("onResume");
        public void OnStart() => Call("onStart");
        public void OnStop() => Call("onStop");
        public void PauseContinuouslyScan() => Call("pauseContinuouslyScan");
        public void ResumeContinuouslyScan() => Call("resumeContinuouslyScan");
        public void SetOnLightVisibleCallback(OnLightVisibleCallBack onLightVisibleCallBack) => Call("setOnLightVisibleCallback", onLightVisibleCallBack);
        public void SetOnResultCallback(OnResultCallback onResultCallback) => Call("setOnResultCallback", onResultCallback);
        public bool SwitchLight => Call<bool>("switchLight");

        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }
            public Builder() : base("com.huawei.hms.hmsscankit.RemoteView$Builder") { }

            private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.hmsscankit.RemoteView$Builder");

            public RemoteView Build() => CallAsWrapper<RemoteView>("build");

            public Builder EnableReturnBitmap() => CallAsWrapper<Builder>("enableReturnBitmap");
            public Builder SetBoundingBox(Rect rect) => CallAsWrapper<Builder>("setBoundingBox", rect);
            public Builder SetContext() => CallAsWrapper<Builder>("setContext", AndroidContext.ActivityContext);
            public Builder SetContinuouslyScan(bool continuouslyScan) => CallAsWrapper<Builder>("setContinuouslyScan", continuouslyScan);
            public Builder SetFormat(int format) => CallAsWrapper<Builder>("setFormat", format);

        }
    }

}