package org.m0skit0.android.hms.unity.ads;

public class OnMetadataChangedListenerWrapper extends com.huawei.hms.ads.reward.OnMetadataChangedListener {

    private final OnMetadataChangedListener listener;

    public OnMetadataChangedListenerWrapper(final OnMetadataChangedListener listener) {
        super();
        this.listener = listener;
    }

    @Override
    public void onMetadataChanged() {
        listener.onMetadataChanged();
    }
}
