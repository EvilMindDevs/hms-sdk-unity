package org.m0skit0.android.hms.unity.nearby;

import com.huawei.hms.nearby.transfer.Data;
import com.huawei.hms.nearby.transfer.TransferStateUpdate;

public class DataListenerWrapper extends com.huawei.hms.nearby.transfer.DataCallback {

    private final DataListener listener;

    public DataListenerWrapper(final DataListener listener) {
        super();
        this.listener = listener;
    }
    @Override
    public void onReceived(String s, Data data) {
        listener.onReceived(s, data);
    }
    @Override
    public void onTransferUpdate(String s, TransferStateUpdate transferStateUpdate) {
        listener.onTransferUpdate(s, transferStateUpdate);
    }
}