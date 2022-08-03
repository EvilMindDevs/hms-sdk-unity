package org.m0skit0.android.hms.unity.location;

import android.content.Intent;

public class BroadcastWrapper implements BroadcastListener {

    private final BroadcastListener listener;

    public BroadcastWrapper(BroadcastListener listener) {
        super();
        this.listener = listener;
    }

    @Override
    public void onReceive(Intent intent) {
        listener.onReceive(intent);
    }
}
