namespace HuaweiMobileServices.Game
{
    using System.Collections.Generic;
    using HuaweiMobileServices.Base;

    // Wrapper for com.huawei.hms.jos.games.EventsClient
    public interface IEventsClient
    {
        void Grow(string aString, int aInt);

        ITask<IList<Event>> GetEventList(bool paramBoolean);

        ITask<IList<Event>> GetEventListByIds(bool paramBoolean, params string[] paramVarArgs);
    }

}