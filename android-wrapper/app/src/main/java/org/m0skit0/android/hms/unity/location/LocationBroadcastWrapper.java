package org.m0skit0.android.hms.unity.location;

import android.content.Intent;

public class LocationBroadcastWrapper implements LocationBroadcastListener {

    private final LocationBroadcastListener listener;

    public LocationBroadcastWrapper(LocationBroadcastListener listener) {
        super();
        this.listener = listener;
    }

    @Override
    public void onReceive(Intent intent) {
        listener.onReceive(intent);
    }
}
