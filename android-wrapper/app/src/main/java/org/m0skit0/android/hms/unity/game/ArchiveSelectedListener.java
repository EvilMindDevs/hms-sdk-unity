package org.m0skit0.android.hms.unity.game;

import android.content.Intent;

public interface ArchiveSelectedListener {
    void onSuccess(final Intent data);
    void onFailure(final Exception exception);
}
