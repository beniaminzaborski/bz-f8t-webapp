using Bz.F8t.WebApp.ApiClients.Dtos;
using Refit;

namespace Bz.F8t.WebApp.ApiClients;

public interface IRegistrationApi
{
    [Post("/api/registration/register")]
    Task<IApiResponse> RegisterAsync(RegistrationRequestDto dto);

    [Get("/api/competitor/")]
    Task<ApiResponse<IEnumerable<CompetitorDto>>> GetCompetitorsAsync(Guid competitionId);
}
