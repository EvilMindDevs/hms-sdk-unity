package org.m0skit0.android.hms.unity.scan;

public class OnLightVisibleCallBackWrapper implements com.huawei.hms.hmsscankit.OnLightVisibleCallBack {

    private final OnLightVisibleCallBack listener;

    public OnLightVisibleCallBackWrapper(final OnLightVisibleCallBack listener) {
        super();
        this.listener = listener;
    }

    @Override
    public void onVisibleChanged(boolean b) {
        listener.onVisibleChanged(b);
    }
}
