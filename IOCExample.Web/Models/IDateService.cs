using System;

namespace IOCExample.Web.Models
{
    public interface IDateService
    {
        DateTime GetDateTime { get; }
    }

    public interface ISingletonDataService : IDateService { }
    public interface IScopedDateService : IDateService { }
    public interface ITransientDateService : IDateService { }
}
