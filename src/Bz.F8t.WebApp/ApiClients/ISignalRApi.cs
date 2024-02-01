using Bz.F8t.WebApp.ApiClients.Dtos;
using Refit;

namespace Bz.F8t.WebApp.ApiClients;

public interface ISignalRApi
{
    [Post("/api/negotiate")]
    Task<SignalRConnectionInfoDto> SignalRNegotiateAsync();
}
