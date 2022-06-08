using System;

namespace IOCExample.Web.Models
{
    public interface IDateService
    {
        DateTime GetDateTime { get; }
    }

    interface ISingletonDataService : IDateService { }
    interface IScopedDateService : IDateService { }
    interface ITransientDateService : IDateService { }
}
