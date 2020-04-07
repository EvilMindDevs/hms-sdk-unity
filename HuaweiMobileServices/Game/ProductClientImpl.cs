using System.Collections.Generic;

namespace com.huawei.hms.jos.product
{
    using ApiException = com.huawei.hms.common.ApiException;
    using Context = android.content.Context;
    using e = com.huawei.hms.support.api.game.d.e;
    using GamesBaseClientImpl = com.huawei.hms.jos.games.GamesBaseClientImpl;
    using HiAnalyticsClient = com.huawei.hms.support.hianalytics.HiAnalyticsClient;
    using JSONObject = org.json.JSONObject;
    using TaskCompletionSource = com.huawei.hmf.tasks.TaskCompletionSource;

    public class ProductClientImpl : GamesBaseClientImpl, ProductClient
    {
        public ProductClientImpl(Context paramContext) : base(paramContext, null)
        {
        }

        public virtual Task<IList<ProductOrderInfo>> GetMissProductOrder(Context paramContext)
        {
            string str = HiAnalyticsClient.reportEntry(Context, "jos.getMissProductOrder", e.b(Context));
            ApiException apiException = CheckInit();
            if (apiException != null)
            {
                TaskCompletionSource taskCompletionSource = new TaskCompletionSource();
                taskCompletionSource.Exception = apiException;
                return taskCompletionSource.Task;
            }
            JSONObject jSONObject = new JSONObject();
            jSONObject = AttachBaseRequest(jSONObject);
            return doWrite(new GetMissProductOrderTaskApiCall("jos.getMissProductOrder", jSONObject.ToString(), str));
        }
    }

}