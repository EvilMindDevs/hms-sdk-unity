using System.Collections.Generic;

namespace com.huawei.hms.jos.games
{
    using Event = com.huawei.hms.jos.games.@event.Event;
    using HuaweiApiInterface = com.huawei.hms.common.HuaweiApiInterface;

    // Wrapper for com.huawei.hms.jos.games.EventsClient
    public interface IEventsClient : HuaweiApiInterface
    {
        void Grow(string paramString, int paramInt);

        Task<IList<Event>> GetEventList(bool paramBoolean);

        Task<IList<Event>> GetEventListByIds(bool paramBoolean, params string[] paramVarArgs);
    }

}