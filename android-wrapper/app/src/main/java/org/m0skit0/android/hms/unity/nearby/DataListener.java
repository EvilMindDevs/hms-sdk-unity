package org.m0skit0.android.hms.unity.nearby;

import com.huawei.hms.nearby.transfer.Data;
import com.huawei.hms.nearby.transfer.TransferStateUpdate;

public interface DataListener {
    void onReceived(String endpointId, Data data);
    void onTransferUpdate(String endpointId, TransferStateUpdate update);
}
